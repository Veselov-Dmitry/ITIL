using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
//using Office = Microsoft.Office.Core;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace ITIL
{
    class Work
    {
   

        static public int connectTry=0;
        static public bool flagConnect = false;
        public Form1 test=null;
       

        static int raz = 0;
        private static System.Timers.Timer aTimer;
        /// <summary>
        /// Генерирует отчет об ошибке
        /// </summary>
        public void Error(Exception exception) {
            string errMsg = exception.StackTrace;
            string path = "c:\\Users\\" + SystemInformation.UserName + "\\Errs.dat";
            if (File.Exists(path))
                File.Delete(path);
            using (FileStream fs = File.Open(path, FileMode.OpenOrCreate))
            {
                StringBuilder value = new StringBuilder();
                value.Append("-==================================================\n");
                string date = DateTime.Now.ToString("dd.MM.yyyy  HH:mm:ss");
                value.Append(date);
                value.Append(errMsg);
                byte[] info = new UTF8Encoding(true).GetBytes(value.ToString());
                fs.Write(info, 0, info.Length);
            }
            Environment.Exit(0);
        }
        /// <summary>
        /// создаем COM-объект Search (Login())
        /// </summary>
        Thread form = new Thread(startForm);

        private static void startForm(object obj)
        {
            Application.Run(new FormCon());
        }

        public void ComSearch()
        {
            Work art = new Work();
            int fuse = 0;// предохранитель для однократного входа в условие в циле
            try
            {
                int log;
                SetTimer();//таймер, который следит за временем отклика при выполнении метода Login()
                Work conn = new Work();
                do
                {
                    Program.S4App = new TS4App();
                    log = Program.S4App.Login();

                    aTimer.Stop(); aTimer.Dispose();//если Login() отработал сбрасываем и останавливаем таймер
                    Thread.Sleep(1000);
                    connectTry++;
                    if ((log != 1)&(fuse == 0))//одноразовый вход для создания окна ожидания соединения
                    {
                        fuse = 1;//запираем предохранитель
                        form.Start();
                    }   
                }while(log != 1);
                form.Abort();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Обработана " + exception, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Error(exception);// Запись в лог конкретику
            }
            return;
        }
        private static void SetTimer()
        {
            aTimer = new System.Timers.Timer(30000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;

            // Запуск таймера
            aTimer.Enabled = true;
        }
       
        private static void OnTimedEvent(object sender, EventArgs e)
        {
            if (raz > 3) Environment.Exit(0);
            raz++;
            MessageBox.Show("Провышено время(30 секунд) ожидания ответа Search " + raz + " раз\nНа 5-ый раз произойдет завершение программы", "Превышение времени ожидания", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        /// <summary>
        /// Запись в поля формы заявки данных о пользователе
        /// </summary>
        public void InfoUser( TextBox otdel, TextBox fio, TextBox tabNo, TextBox telefon, ComboBox invNoObor )
        {
            try
            {
                int id = Program.S4App.GetUserID();

                Program.S4App.OpenQuery("select g.name_group from grpingrp l inner join grpingrp l2 on l2.group_id = l.ingroup_id and l2.ingroup_id <> 999999998 inner join groups g on  g.group_id = l.ingroup_id and g.group_code <> \"\"inner join groups g2 on g2.group_id = l.group_id and g2.user_id =" + id);
                otdel.Text = ""+Program.S4App.QueryFieldByName("NAME_GROUP");// узнаем Отдел
                Program.S4App.CloseQuery();
                if (otdel.Text.Length > 1) otdel.BackColor = System.Drawing.Color.AliceBlue;

                fio.Text = ""+Program.S4App.GetUserFullName_ByUserID(id);//узнаем ФИО
                if (fio.Text.Length > 1) fio.BackColor = System.Drawing.Color.AliceBlue;

                tabNo.Text = ""+SystemInformation.UserName; //узнаем табельный номер
                if (tabNo.Text.Length > 1) tabNo.BackColor = System.Drawing.Color.AliceBlue;

                Program.S4App.OpenQuery("select WORKPHONE from USERS_INFO where USER_ID =" + id);
                telefon.Text = ""+Program.S4App.QueryFieldByName("WORKPHONE"); //узнаем номер телефона
                Program.S4App.CloseQuery();
                if (telefon.Text.Length > 1) telefon.BackColor = System.Drawing.Color.AliceBlue;

         
                invNoObor.Text = "" + System.Environment.MachineName;// узнаем инвентарный номер оборудования
                if( invNoObor.Text.Length > 1 ) invNoObor.BackColor = System.Drawing.Color.AliceBlue;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show("" + exception, "Ошибка при чтении  иформации о пользователе\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Error(exception);// Запись в лог конкретику
            }


 
            return;
        }
        /// <summary>
        /// Чтение конфига, содежащего типы заявок с их параметрами
        /// </summary>
        public string[][] ReadConfig(System.Windows.Forms.ComboBox tipZayavki)
        {
            string[][] selected = new string[10][];// буде результирующим массивом
            try
            {
                int i = 0;
                string[] readText = (File.ReadAllText(@"\\sql-main\IM\Application\ITIL\CONFIG.INI", Encoding.Default)).Split('\n');//читаем из файла в массив строк
                int step = 0;

                for (i = 0; i < readText.Length; i++)//проходим по всему массиву строк
                    if ((readText[i])[0].ToString().CompareTo(";") != 0)// точка с запятой на подобие коментария и не принимается в новый массив
                    {
                        selected[step] = new string[10];//необходимая инициализация подмассива
                        string[] lineWord = readText[i].Replace("\t", String.Empty).Split(',');//избавляемся от табуляций э строке и разбиваем строку на массив слов
                        for (int j = 0; j < lineWord.Length; j++)//проргоняем по массиву из слов
                            selected[step][j] = lineWord[j];// и записывыем в результирующий массив
                        tipZayavki.Items.Add(selected[step][3]);// заполняем список типов заявок
                        step++;
                    }

                //tipZayavki.Items.Add( "В сервисную службу ОАСУ" );// заполняем список типов заявок
                //tipZayavki.Items.Add( "Технол. оборудование" );// заполняем список типов заявок
                tipZayavki.SelectedIndex = 0;// для отображения самого первого элемента из списка в форме заявки
            }
            catch (Exception exception)
            {
                MessageBox.Show("" + exception, "Ошибка при чтении и занесении иформации о конфиге\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Error(exception);// Запись в лог конкретику
            }
            return selected;
        }
        /// <summary>
        /// Запуск шаблона и передача данных
        /// </summary>
        public void Register(string[] infoUser, string[] dataConfig, System.Windows.Forms.ProgressBar progrBar )
        { /* infoUser[0] Отдел
           * infoUser[1] ФИО
           * infoUser[2] Теб№
           * infoUser[3] Телефон
           * infoUser[4] Инв№ обор
           * infoUser[5] Описание проблемы
           * infoUser[6] Путь к доп файлу
           * infoUser[7] Название оборудования только для ПДС
           * infoUser[8] Кому придет заявка только для ПДС cсписок
           * infoUser[9] Приоритет ремонта
           * dataConfig[3] (прим. значения: В отдел главного механика		
           + dataConfig[0]   id типа документа \n"
           + dataConfig[1]   id архива для регистрации\n"
           + dataConfig[2]   id маршрута согласования\n"
           + dataConfig[3]   название\n"
           + dataConfig[4]   наименование документа\n"
           + dataConfig[5]   папка классификатора в Search /**/
            try
            {
                progrBar.Value = 10;
                string file_ext = "doc";
                int object_type = 0;
                int doc_type = int.Parse(dataConfig[0]);//id типа документа                      (прим. значения: 1000121)
                int archive_id = int.Parse(dataConfig[1]);//id архива для регистрации            (прим. значения: 621)
                int process_template_id = int.Parse( dataConfig[ 2 ] );//id маршрута согласования    (прим. значения: 254283)
                string classif_folder = dataConfig[5];//папка классификатора в Search            (прим. значения: ПДС)
                string doc_name = dataConfig[4];//наименование документа                         (прим. значения: Заявка в ОГМ)
                string folder = @"D:\SEARCHWORK\";
                string otmetka;
                string nameProcess;
                /*---=== Запуск процесса без диалога с пользователем===---*/
                var AppServer = Program.S4App.GetSbServer();// получаем объект sbserver;
                var Router = AppServer.GetRouter();// получаем объект Router;
                var Process = Router.CreateProcess(process_template_id);//id маршрута согласования    254283
                var procVars = Process.StartActivity.Variables;//подключение к переменным процесса
                progrBar.Value = 20;
                var s4Classificator = Program.S4App.GetClassificatorInterface();// GetClassificatorInterface для доступа к работе с классификаторами 
                progrBar.Value = 30;
                string FolderKey = s4Classificator.OpenFolderByName(classif_folder);// OpenFolderByName открывает папку классификатора по ее полному имени и возвращает идентификатор открытой папки
                progrBar.Value = 45;
                string designation = s4Classificator.GetDesignationByKey(FolderKey, "");// GetDesignationByKey возвращает сгенерированное обозначение для папки классификатора.
                progrBar.Value = 50;
                string filename = Program.S4App.GenerateFileName("", file_ext);//GenerateFileName генерирует уникальное имя файла для новых документов Search. 
                progrBar.Value = 60;
                string fullfilename = folder + filename;

                if (Directory.Exists(folder) == false)  Directory.CreateDirectory(folder);

                progrBar.Value = 70;
                int doc_id = Program.S4App.CreateFileDocumentWithDocType2(fullfilename, doc_type, archive_id, filename, "", object_type);//CreateFileDocumentWithDocType2 создает в архиве новый файловый документ и возвращает его инвентарный номер. 
                progrBar.Value = 80;
                Program.S4App.OpenDocument(doc_id);
                if (infoUser[6] != "")  Program.S4App.AppendAdvanFile2(infoUser[6], 0);//прикрепляем доп файл

                Program.S4App.SetFieldValue("DESIGNATIO", designation);//SetFieldValue присваивает значение указанному параметру текущего документа. 
                Program.S4App.SetFieldValue("NAME", doc_name);//           -//-
                Program.S4App.SetFieldValue("FIO", infoUser[1]);//         -//-
                Program.S4App.SetFieldValue("PROBLEM", infoUser[5]);//     -//-
                Program.S4App.SetFieldValue("OTMETKA" , "Не выполнено" );//-//-
                if( classif_folder != "Журнал работ БРОВТ" )
                {
                    Program.S4App.SetFieldValue("NAZV_OBORUD" , infoUser[7]);
                    Program.S4App.SetFieldValue("LAST_WHEN_WHOM" , infoUser[8].Split(new char[] { '\r' , '\n' } )[0] );
                    otmetka = "Конфликт";
                    nameProcess = "Заявка. инв№ \"" + infoUser[ 4 ] + "\". сервис № " + designation + "  " + infoUser[ 0 ];


                    string group = infoUser[ 8 ].Split( new char[] { '\r' , '\n' } )[ 0 ];
                    string sqlQuery = "SELECT GROUP_ID   FROM DBO.GROUPS     WHERE NAME_GROUP = 'ITIL PDS " + group + "'";
                    Program.S4App.OpenQuery( sqlQuery );
                    string grourID = Program.S4App.QueryFieldByName( "GROUP_ID" );
                    procVars.GetVariableByName( "ISPOLNITEL" ).asString = grourID + "=1";
                    procVars.GetVariableByName( "PRIORITET" ).asString = infoUser[ 9 ];
                    string res = " \r\n" + infoUser[ 8 ];
                    procVars.GetVariableByName( "SQL_group" ).asString = res;
                }
                else{
                    otmetka = "Выполнено частично";
                    nameProcess = doc_name + " в сервис № " + designation;
                }
                Program.S4App.CheckIn();//возвращает в архив текущий документ, если он взят на изменение вошедшим в Search пользователем. 
                s4Classificator.IncludeDocument(doc_id);//IncludeDocument включает в состав текущей открытой папки классификатора документ с инвентарным номером DocID.
                Process.StartActivity.Attachments.AddLink(doc_id);//прикрепим этот документ как вложение
                procVars.GetVariableByName( "OTMETKA" ).asString = "Не выполнено\r\nНе выполнено\r\nВыполнено\r\n" + otmetka + "\r\n";
                procVars.GetVariableByName("ZAYAVKA").value = designation;
                procVars.GetVariableByName("TITLE").value = "Заявка № " + designation + " от " + Program.S4App.GetFieldValue("CREATEDATE");
                procVars.GetVariableByName("CREATEDATE").value = Program.S4App.GetFieldValue("CREATEDATE");
                //переменная "OTMETKA" в Search имеет тип список строк,
                //при передаче в список строк в Search  передача идет по шаблону :
                //"<Значение по умолчанию>,1 элемент сппскаб 2 элемент списка. и т.д."
                progrBar.Value = 90;
                procVars.GetVariableByName("OTDEL").value = infoUser[0];
                procVars.GetVariableByName("PROBLEM").value = infoUser[5];
                procVars.GetVariableByName("LOGIN").value = infoUser[2];
                procVars.GetVariableByName("KONTRDATE").value = DateTime.Now.ToString("dd.MM.yyyy");
                procVars.GetVariableByName("KONTRTIME").value = DateTime.Now.AddHours(2).ToString("HH:mm:ss");
                procVars.GetVariableByName("FIO").value = infoUser[1];
                procVars.GetVariableByName("INVNOMER").value = infoUser[4];
                procVars.GetVariableByName("TEL").value = infoUser[3];
                Process.Start();

                if( classif_folder != "Журнал работ БРОВТ" )
                        Process.Name = nameProcess;
                else
                    Process.Name = nameProcess;
                Program.S4App.CloseDocument( );
                progrBar.Value = 100;

            }
            catch (Exception exception)
            {
                MessageBox.Show("" + exception, "Ошибка при запуске процесса заявки", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Error(exception);// Запись в лог конкретику
            }
            return;
        }

         /// <summary>
        /// Получает список групп с названием начинающимся на "ITIL PDS "
        /// </summary>
        /// <returns>12</returns>
        internal string[] getIspolnitelList()
        {
            List<string> op = new List<string>( );
            Program.S4App.OpenQuery( @"SELECT NAME_GROUP
                  FROM Search.dbo.GROUPS
                  WHERE NAME_GROUP LIKE 'ITIL PDS%'" );
            do
            {
                string po = Program.S4App.QueryFieldByName( "NAME_GROUP" );
                //Временно для отображения списка только относяцихся к корпусу №1
                if(po.IndexOf("-")<1)
                    op.Add( po.Substring(9) );
                
            }
            while( Program.S4App.QueryGoNext( ) != 0 );
            Program.S4App.CloseQuery( );
            return op.ToArray();
        }

        /// <summary>
        /// Отчет в MS Office Word по заявкам текущего пользователя
        /// </summary>
        public void Report(string fio,int arh)
        {
            try
            {
                Program.S4App.OpenQuery(@"select ALIAS from ARCHIVES where ARCHIVE_ID = " + arh);//OpenQuery Эта функция позволяет выполнить произвольный SQL-запрос
                string alias = Program.S4App.QueryFieldByName("ALIAS");//QueryFieldByName Эта функция позволяет получить значение поля FieldName в текущей записи полученной выборки
                Program.S4App.CloseQuery();//CloseQuery Эту функцию следует использовать по завершении работы с открытым запросом
                Program.S4App.OpenQuery("select p. doc_id, d.DESIGNATIO, d.CREATEDATE, p.PROBLEM, p.OTMETKA, p.ISPOLNITEL, p.DATEISP, p.TIMEISP, p.USERNOTE from " + alias + " p left join  doclist d on p.doc_id = d.doc_id where FIO like '" + fio + "%' order by d.CREATEDATE");
            }
            catch (Exception exception)
            {
                MessageBox.Show("" + exception, "Ошибка при работе с БД Search\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Error(exception);// Запись в лог конкретику
            }

            //Работа с MS Office Word
            try
            {
                Object filename = @"\\sql-main\IM\Application\Report Templates\Отчет по заявкам в сервис ОАСУ.dot";
                Word.Application Progr = new Microsoft.Office.Interop.Word.Application();
                Progr.Documents.Open(ref filename);
                Word.Document Doc = new Microsoft.Office.Interop.Word.Document();
                Doc = Progr.Documents.Application.ActiveDocument;
                Word.Table newTable = Doc.Tables[1];
                newTable.Cell(1, 2).Range.Text = fio;
                Program.S4App.QueryGoFirst();//QueryGoFirst Эта функция переходит к первой записи в полученной выборке данных
                int j = 4;// 4 - следует из построения шаблона документа MS Office Word
                while (Program.S4App.QueryEOF() == 0)//QueryEOF Данная функция позволяет определить, достигнут ли конец выборки данных, без перемещения курсора в этой выборке данных. 
                {
                    if (j > 4) newTable.Rows.Add();
                    newTable.Cell(j, 1).Range.Text = "" + Program.S4App.QueryFieldByName("DESIGNATIO");
                    newTable.Cell(j, 2).Range.Text = "" + Program.S4App.QueryFieldByName("CREATEDATE");
                    string problem = "" + Program.S4App.QueryFieldByName("PROBLEM");
                    StringBuilder problemFormat = new StringBuilder(300);           //
                    if (problem.Length > 94)                                        //
                    {                                                               //
                        for (int i = 0; i < problem.Length; i++)                    //
                        {                                                           // перенос строк в длинных зяписях
                            problemFormat.Append(problem[i]);                       //
                            if ((i % 94 == 0) & (i != 0))                           //
                                problemFormat.Append("\n");                         //
                        }                                                           //
                        newTable.Cell(j, 3).Range.Text = problemFormat.ToString();  //
                    }
                    else
                        newTable.Cell(j, 3).Range.Text = problem;
                    newTable.Cell(j, 4).Range.Text = "" + Program.S4App.QueryFieldByName("ISPOLNITEL");
                    string dataisp = "" + Program.S4App.QueryFieldByName("DATEISP");
                    string timeisp = "" + Program.S4App.QueryFieldByName("TIMEISP");
                    string dt = dataisp + " " + timeisp;
                    newTable.Cell(j, 5).Range.Text = dt.Replace(@"\r\n", " ");
                    newTable.Cell(j, 6).Range.Text = Program.S4App.QueryFieldByName("USERNOTE");
                    Program.S4App.QueryGoNext();
                    j++;
                }
                Program.S4App.CloseQuery();
                Progr.Visible = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show("" + exception, "Ошибка при работе с MS Office Word либо с БД Search\n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Error(exception);// Запись в лог конкретику
            }
            return;
        }
        /// <summary>
        /// Проверка запущенных процесов
        /// </summary>
        public void CheckProc()
        {
            System.Management.ManagementObjectSearcher Processes = new System.Management.ManagementObjectSearcher("SELECT * FROM Win32_Process");
            string currentProcessName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;//получаем название текущего процесса

            foreach (System.Management.ManagementObject Process in Processes.Get())
            {
                if (Process["ExecutablePath"] != null)
                {
                    string ExecutablePath = "";
                    string[] OwnerInfo = new string[2];
                    try
                    {
                        ExecutablePath = Process["ExecutablePath"].ToString();
                        if( ExecutablePath == "" )
                            continue;
                        Process.InvokeMethod("GetOwner", (object[])OwnerInfo);//берем инфо о процессе в т.ч. имя влядельца процесса
                    }
                    catch
                    {
                        continue;
                    }
                    //MessageBox.Show("1)" + "METZ\\" + OwnerInfo[0] + "=" + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "", "Ать!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if ((System.IO.Path.GetFileName(ExecutablePath) == currentProcessName+".exe") & ("METZ\\"+OwnerInfo[0] == System.Security.Principal.WindowsIdentity.GetCurrent().Name))
                        //проверяем совпадение имени этого процесса и владельца
                    {
                        System.Diagnostics.Process[] processesByName = System.Diagnostics.Process.GetProcessesByName(currentProcessName);//создаем массив из процессов, что бы убить их

                        if (processesByName.Length > 1)//если запущено более одного процесса- убиваем все
                        {
                            MessageBox.Show("Ваше имя пользователя " + System.Security.Principal.WindowsIdentity.GetCurrent().Name + "\nПроцесс заявки " + currentProcessName + ".exe" + " уже запущен у пользователя " + "METZ\\"+OwnerInfo[0] , "Повторый запуск", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            for (int i = 0; i < processesByName.Length; i++)
                                processesByName[i].Kill();//убиваем процессы дублирующиеся

                            Environment.Exit(0);
                        }/**/
                    }
                }
            }

           return;
        }
        
    }
}
