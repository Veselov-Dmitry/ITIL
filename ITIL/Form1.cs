using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using S4;
using System.Threading;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace ITIL
{
    public partial class Form1 : Form
    {
        Work workClass = new Work();
        
        public Form1()
        {
            InitializeComponent();
        }

        public bool switchForm
        {
            get{
                return state;
            }
            set{
                otmena.Enabled = value;
                otchet.Enabled = value;
                otpravit.Enabled = value;
                labelTipZayavki.Enabled = value;
                otdel.Enabled = value;
                fio.Enabled = value;
                tabNo.Enabled = value;
                telefon.Enabled = value;
                opisanieProblemi.Enabled = value;
                labelOtdel.Enabled = value;
                labelFio.Enabled = value;
                labelTabNo.Enabled = value;
                labelTelefon.Enabled = value;
                labelInvNoObor.Enabled = value;
                labelOpisanieProblemi.Enabled = value;
                labelVvodSimv.Enabled = value;
                panel1.Enabled = value;
                tipZayavki.Enabled = value;
                panel2.Enabled = value;
                invNoObor.Enabled = value;
                nazvOborud.Enabled = value;
                labelPrikrepitFail.Enabled = value;
                obzor.Enabled = value;
                Prikrepitfail.Enabled = value;
                ispolnitelLabel.Enabled = value;
                ispolnitelList.Enabled = value;
                panel3.Enabled = value;
                state = value;
                this.Cursor = ( value ) ? System.Windows.Forms.Cursors.Default : System.Windows.Forms.Cursors.WaitCursor;
            }
        }

        public string ispolnitelAsString
        {
            get {
                if( tipZayavki.SelectedIndex == 1 )
                {

                    string list = "";
                    foreach( var item in ispolniteli )
                    {
                        list += item + "\r\n";
                    }
                    list = ispolnitelList.Text + "\r\n" + list;
                    return list;
                }
                else
                    return "";
            }
        }

        private void obzor_Click( object sender , EventArgs e )
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // Set filter options and filter index.
            openFileDialog1.Filter = "All Files (*.*)|*.*";//"Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = false;
            // Call the ShowDialog method to show the dialog box.
            openFileDialog1.ShowDialog();
            Prikrepitfail.Text = openFileDialog1.FileName;
        }


        private void otmena_MouseClick(object sender, MouseEventArgs e)
        {
            Environment.Exit(0);
        }

        private void opisanieProblemi_KeyPress(object sender, KeyEventArgs e)
        {
            int n = opisanieProblemi.Text.Length;
            labelVvodSimv.Text = "Вы ввели " + n + " символов (макс.255)";
        }

        #region Цветовое выделение пустых и заполненных полей, а также язык ввода

            private void invObor_Enter( object sender , EventArgs e )
            {
                invNoObor.BackColor = Color.AliceBlue;
            }
            private void invObor_Leave( object sender , EventArgs e )
            {
                if( invNoObor.Text.Length < 1 )
                    invNoObor.BackColor = Color.MistyRose;
            }
            private void opisanieProblemi_EnabledChanged(object sender, EventArgs e)
            {
                opisanieProblemi.BackColor = System.Drawing.Color.AliceBlue;
                //InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));

            }

            private void          opisanieProblemi_Enter(object sender, EventArgs e)
            {
                opisanieProblemi.BackColor = System.Drawing.Color.AliceBlue;
                //руский язык ввода в данном поле
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
            }

            private void          opisanieProblemi_Leave(object sender, EventArgs e)
            {
                if (opisanieProblemi.Text.Length < 1) 
                {
                    opisanieProblemi.BackColor = System.Drawing.Color.MistyRose;
                }
            }

            private void                 invNoObor_Enter(object sender, EventArgs e)
            {
                invNoObor.BackColor = System.Drawing.Color.AliceBlue;
                //английский язык ввода в данном поле
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("en-US"));
            }

            private void                 invNoObor_Leave(object sender, EventArgs e)
            {
                if (invNoObor.Text.Length < 1)
                    invNoObor.BackColor = System.Drawing.Color.MistyRose;
            }

            private void                   telefon_Enter(object sender, EventArgs e)
            {
                telefon.BackColor = System.Drawing.Color.AliceBlue;
            }

            private void                   telefon_Leave(object sender, EventArgs e)
            {
                if (telefon.Text.Length < 1)
                    telefon.BackColor = System.Drawing.Color.MistyRose;
            }

            private void                     tabNo_Enter(object sender, EventArgs e)
            {
                tabNo.BackColor = System.Drawing.Color.AliceBlue;
            }

            private void                     tabNo_Leave(object sender, EventArgs e)
            {
                if (tabNo.Text.Length < 1)
                    tabNo.BackColor = System.Drawing.Color.MistyRose;
            }

            private void                       fio_Enter(object sender, EventArgs e)
            {
                fio.BackColor = System.Drawing.Color.AliceBlue;
                //руский язык ввода в данном поле
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
            }

            private void                       fio_Leave(object sender, EventArgs e)
            {
                if (fio.Text.Length < 1)
                    fio.BackColor = System.Drawing.Color.MistyRose;
            }

            private void                     otdel_Enter(object sender, EventArgs e)
            {
                otdel.BackColor = System.Drawing.Color.AliceBlue;
                //руский язык ввода в данном поле
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("ru-RU"));
            }

            private void                     otdel_Leave(object sender, EventArgs e)
            {
                if (otdel.Text.Length < 1)
                    otdel.BackColor = System.Drawing.Color.MistyRose;
            }

            private void           chastieProblemi_Leave(object sender, EventArgs e)
            {
                if (opisanieProblemi.Text.Length < 1)
                {
                    opisanieProblemi.BackColor = System.Drawing.Color.MistyRose;
                }
                else
                {
                    opisanieProblemi.BackColor = System.Drawing.Color.AliceBlue;
                }
            }

            private void            ispolnitelList_Leave( object sender , EventArgs e )
            {
                if( ispolnitelList.Text.Length < 1 )
                {
                    opisanieProblemi.BackColor = System.Drawing.Color.MistyRose;
                }
                else
                {
                    opisanieProblemi.BackColor = System.Drawing.Color.AliceBlue;
                }
            }

            private void            ispolnitelList_Enter( object sender , EventArgs e )
            {
                ispolnitelList.BackColor = System.Drawing.Color.AliceBlue;
            }
        #endregion



        private bool state;//Для switchForm

        private string[][] selected = new string[10][];

        static private string[] infoUser = new string[10];

        static private string[] dataConfig = new string[10];

        private string[] ispolniteli;

        private void otpravit_MouseClick(object sender, MouseEventArgs e)
        {
            int t;
            if( tipZayavki.SelectedIndex == 1 )
                t = otdel.Text.Length * fio.Text.Length * tabNo.Text.Length * telefon.Text.Length * invNoObor.Text.Length * opisanieProblemi.Text.Length * ispolnitelList.Text.Length;
            else
                t = otdel.Text.Length * fio.Text.Length * tabNo.Text.Length * telefon.Text.Length * invNoObor.Text.Length * opisanieProblemi.Text.Length;
            if(t==0)
            {
                MessageBox.Show("Заполните все подсвеченные поля");
                //деактивация прогрессбара
                progrBar.Visible = progrPanel.Visible = false;
                //активация полей формы
                switchForm = true;
                return;
            }
            switchForm = false;
            //активация програссбара
            progrBar.Visible = progrPanel.Visible = true;
            
            progrBar.Value = 5;
            string[] infoUser = {
                otdel.Text,
                fio.Text,
                tabNo.Text,
                telefon.Text,
                invNoObor.Text,
                opisanieProblemi.Text,
                Prikrepitfail.Text,
                nazvOborud.Text,
                ispolnitelAsString,
                prioritetOborud.Text};

            string[] dataConfig = selected[tipZayavki.SelectedIndex];
            workClass.Register(infoUser, dataConfig, progrBar);
            Environment.Exit(0);
            /*progrBar.Visible = progrPanel.Visible = false;
            switchForm = true;
            /**/
        }

        private void otchet_MouseClick(object sender, MouseEventArgs e)
        {
            int archive = int.Parse(selected[tipZayavki.SelectedIndex][1]);
            new Work().Report(fio.Text, archive);

            Environment.Exit(0);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            workClass.InfoUser(otdel, fio, tabNo, telefon, invNoObor);
            selected = workClass.ReadConfig(tipZayavki);
            int y = SystemInformation.VirtualScreen.Height;
            int x = SystemInformation.VirtualScreen.Width;          
            switch( getPPI( ) )
            {
                case "96":
                    {
                        if( y < 821 )
                        {

                            this.MinimumSize = new System.Drawing.Size( 450 , 590 );
                            this.MaximumSize = new System.Drawing.Size( 500 , 700 );
                        }
                        else
                        {
                            //x = ( x > 1980 ) ? x / 2 : x;

                            this.MinimumSize = new System.Drawing.Size( 450 , 630 );
                            this.MaximumSize = new System.Drawing.Size( 450 , 630 );
                        }
                        break;
                    }
                case "120":
                    {
                        x = ( x > 1980 ) ? x / 2 : x;
                        //this.MinimumSize = new System.Drawing.Size( 450 , 630 );
                        this.MinimumSize = new System.Drawing.Size( ( x * 35 ) / 100 , ( ( y * 68 ) / 100 ) );
                        this.MaximumSize = new System.Drawing.Size( ( x * 4 ) / 10 , ( ( y * 9 ) / 10 ) );
                        break;
                    }
                case "144":
                    {
                        x = ( x > 1980 ) ? x / 2 : x;
                        this.MinimumSize = new System.Drawing.Size( ( x * 4 ) / 10 , ( ( y * 9 ) / 10 ) );
                        this.MaximumSize = new System.Drawing.Size( ( x * 4 ) / 10 , ( ( y * 9 ) / 10 ) );
                        break;
                    }
                default:
                    {
                        this.MinimumSize = new System.Drawing.Size( ( x * 4 ) / 10 , ( ( y * 9 ) / 10 ) );
                        this.MaximumSize = new System.Drawing.Size( ( x * 4 ) / 10 , ( ( y * 9 ) / 10 ) );
                        break;
                    }
            }
            x = ( x > 1980 ) ? x / 2 : x;
            Location = new Point( ((x/2) - ( this.Width /2) ) , ( ( y / 2 ) - ( this.Height / 2 ) )/2 );
            state = true;
            /////DELETE IT
            //=========================================
            //   tipZayavki.SelectedIndex = 1;
          
            //===========================================
        }

        /// <summary>
        /// получить величину увеличения шрифта ситемой (96 120 144 dpi)
        /// </summary>
        /// <returns></returns>
        private string getPPI()
        {
            const string userRoot = @"HKEY_CURRENT_USER\Control Panel\Desktop";
            const string subkey = "LogPixels";            
            object key = Registry.GetValue( userRoot , subkey , null );
            if( key != null )
            {
                //MessageBox.Show( key.ToString() );
                return key.ToString( );
            }
            return "";
        }    

        private void buttonOtmena_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tipZayavki_SelectedIndexChanged( object sender , EventArgs e )
        {
            if( tipZayavki.SelectedIndex == 1 )
            {
                panel_OASU.Visible = false;
                panel_PDS.Visible = true;
//======================DELETE=IT===============================================
               
//======================DELETE=IT===============================================
                switchForm = false;
                invNoObor.Items.Clear();

                StringBuilder spisDB = new StringBuilder( );
                invNoObor.DropDownStyle = ComboBoxStyle.DropDownList;//не редактируемый список
                string otdelChecked = "";
                #region DB
                try
                {
                    string DBFile = getDbPath( );
                    OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder( );
                    cb.Add( "Provider" , "Microsoft.Jet.OLEDB.4.0" );
                    cb.Add( "Data Source" , DBFile );
                    cb.Add( "User ID" , "Admin" );
                    cb.Add( "Password" , "" );
                    cb.Add( "Persist Security Info" , "False" );
                    OleDbConnection db = new OleDbConnection( cb.ToString( ) );
                    //--------------------------------
                    string queryString = ( @"SELECT DISTINCT Книга.[Место эксплуатации]
                        FROM Книга
                        WHERE (((Книга.[Числится по бухгалтерии])=True)) AND [Место эксплуатации] IS NOT NULL;" );

                    OleDbCommand ODCommandOtd = new OleDbCommand( queryString , db );
                    db.Open( );
                    OleDbDataReader ReaderOtd = ODCommandOtd.ExecuteReader( );
                    string otdelTemp = convertOtdelName( );
                    if( otdelTemp.Length>1 )
                    {
                        otdelChecked = otdelTemp;
                    }
                    else
                    {
                        if( ReaderOtd.HasRows )
                            while( ReaderOtd.Read( ) )
                            {
                                if( ReaderOtd[ "Место эксплуатации" ].ToString( ) == otdel.Text )
                                {
                                    otdelChecked = ReaderOtd[ "Место эксплуатации" ].ToString( );
                                    break;
                                }
                                spisDB.Append( ReaderOtd[ "Место эксплуатации" ].ToString( ) + "  " );
                            }
                        ReaderOtd.Close( );
                    }
//--------------------------------
                        if( otdelChecked.Length > 1 )
                        {
                            queryString = ( @"SELECT Книга.[Инвентарный №]
                            FROM Книга
                            WHERE (((Книга.[Место эксплуатации])='" + otdelChecked + @"'))
                            ORDER BY Книга.[Инвентарный №];" );

                            OleDbCommand ODCommand = new OleDbCommand( queryString , db );
                            OleDbDataReader Reader = ODCommand.ExecuteReader( );
                            if( Reader.HasRows )
                                while( Reader.Read( ) )
                                {
                                    invNoObor.Items.Add( Reader[ "Инвентарный №" ] );
                                }
                            Reader.Close( );
                        }
                    else
                    {
                        MessageBox.Show( "В названии отдела могут быть только следующие названия подразделений:\n\n"+spisDB.ToString(),"Внимание");
                        tipZayavki.SelectedIndex = 0;
                    }
                    db.Close( );
                    #endregion
                    if( invNoObor.Items.Count!=0)
                        invNoObor.SelectedItem = 0;
                    
                }
                catch( Exception we )
                {
                    MessageBox.Show( we.Message + "\n" + we.StackTrace , "" );
                }
                //выгрузка списка исполнителей
                ispolnitelList.Items.Clear();
                ispolniteli = workClass.getIspolnitelList( );
                ispolnitelList.Items.AddRange( ispolniteli );
                
                /**/
                invNoObor.BackColor = System.Drawing.Color.MistyRose;
                ispolnitelList.BackColor = System.Drawing.Color.MistyRose;
                switchForm = true;
                //======================DELETE=IT===============================================
                /*
                ispolniteli = new string[] { "1" , "2" , "3" };
                invNoObor.DropDownStyle = ComboBoxStyle.DropDownList;//не редактируемый список
                invNoObor.Items.AddRange( ispolniteli );
                invNoObor.SelectedIndex = 1;
                invNoObor.Text = "1212";
                ispolnitelList.SelectedIndex = 1;
                opisanieProblemi.Text = "123123";
                
                nazvOborud.Text = "Наименование оборудования";
                prioritetOborud.Text = "2";/**/

                //==========================================================================

            }
            else
            {
                invNoObor.DropDownStyle = ComboBoxStyle.DropDown;//редактируемый список
                invNoObor.Text = "" + System.Environment.MachineName;// узнаем инвентарный номер оборудования
                invNoObor.BackColor = System.Drawing.Color.AliceBlue;
                nazvOborud.Text = "";
                panel_OASU.Visible = true;
                panel_PDS.Visible = false;
                switchForm = true;
                ispolnitelList.Items.Clear( );
                ispolnitelList.Items.Add( "пусто" );
            }
        }

        private string getDbPath()
        {
            string DBFileNowell = @"T:\Info\METZ\ОГМ\База оборудования.mdb";
            string DBFileSql_main = @"\\sql-main\Application\1221\База оборудования.mdb";
            string DBFileSql_main1 = @"\\sql-main\Application\1211\База оборудования.mdb";
            string DBFileSql_main2 = @"\\sql-main\IM\Application\1211\База оборудования.mdb";
            string DBFile = "";
            DialogResult dr = DialogResult.None;
            do
            {
                if( File.Exists( DBFileNowell ) )
                {
                    DBFile = DBFileNowell;
                }
                else if( File.Exists( DBFileSql_main ) )
                {
                    DBFile = DBFileSql_main;
                }
                else if( File.Exists( DBFileSql_main1 ) )
                {
                    DBFile = DBFileSql_main1;
                }
                else if( File.Exists( DBFileSql_main2 ) )
                {
                    DBFile = DBFileSql_main2;
                }
                else
                {
                    string mess = "При попытке обратиться к файлу\n" +
                                  "базы данных произошла ошибка - 'Файл не найден'\n" +
                                  "поиск производился по путям:\n\n" +
                                   DBFileNowell + "\n" +
                                   DBFileSql_main + "\n" +
                                   DBFileSql_main1 + "\n" +
                                   DBFileSql_main2 + "\n\n" +
                                   "Повторить поиск?" + "\n\n\n" +
                                   "(в случае повторения ошибки обратитесь в БССО ОАСУ или создайте заявку)";
                    dr = MessageBox.Show( mess , "Ошибка" , MessageBoxButtons.RetryCancel , MessageBoxIcon.Error );
                }
            } while( dr == DialogResult.Retry );
            if( dr == DialogResult.Cancel )
                Environment.Exit( 0 );
            return DBFile;
        }

        private string convertOtdelName()
        {
            switch( otdel.Text  )
            {
                case "ЦЕХ №1":
                    return @"Ц.1";

                case "ЦЕХ №2":
                    return @"Ц.2')) OR (((Книга.[Место эксплуатации])='Ц.2/Ц.3";

                case "ЦЕХ №3":
                    return @"Ц.3')) OR (((Книга.[Место эксплуатации])='Ц.2/Ц.3')) OR (((Книга.[Место эксплуатации])='Ц.3(4)";

                case "ЦЕХ №4":
                    return @"Ц.4')) OR (((Книга.[Место эксплуатации])='Ц.3(4)";

                case "ЦЕХ №5":
                    return @"Ц.5";

                case "ЦЕХ №6":
                    return @"Ц.6";

                case "ЦЕХ №7":
                    return @"Ц.7')) OR (((Книга.[Место эксплуатации])='Ц.9/Ц.7";

                case "ЦЕХ №9":
                    return @"Ц.9')) OR (((Книга.[Место эксплуатации])='Ц.9/Ц.11')) OR (((Книга.[Место эксплуатации])='Ц.9/Ц.7";

                case "ЦЕХ №10":
                    return @"Ц.10')) OR (((Книга.[Место эксплуатации])='Ц.10 (СЗОС)')) OR (((Книга.[Место эксплуатации])='Ц.10 Сморгонь";

                case "ЦЕХ №11":
                    return @"Ц.11')) OR (((Книга.[Место эксплуатации])='Ц.11 Лида')) OR (((Книга.[Место эксплуатации])='Ц.9/Ц.11";

                case "ЦЕХ №12":
                    return @"Ц.12";

                case "ЦЕХ №15":
                    return @"Ц.15";

                case "ЦЕХ №16":
                    return @"Ц.16";

                case "ЦЕХ №18":
                    return @"Ц.18";

                case "БСАПР ОАСУ":
                    return @"Ц.9')) OR (((Книга.[Место эксплуатации])='Ц.9/Ц.11')) OR (((Книга.[Место эксплуатации])='Ц.9/Ц.7";

                default: return "";
            }
        }

        private void invNoObor_SelectedIndexChanged( object sender , EventArgs e )
        {
            if( tipZayavki.SelectedIndex == 1 )
            {
                    try
                {
                    string DBFile = getDbPath( );
                    OleDbConnectionStringBuilder cb = new OleDbConnectionStringBuilder( );
                    cb.Add( "Provider" , "Microsoft.Jet.OLEDB.4.0" );
                    cb.Add( "Data Source" , DBFile );
                    cb.Add( "User ID" , "Admin" );
                    cb.Add( "Password" , "" );
                    cb.Add( "Persist Security Info" , "False" );
                    OleDbConnection db = new OleDbConnection( cb.ToString( ) );
                    string queryString = ( @"SELECT Книга.[Наименование оборудования]
                    FROM Книга
                    WHERE (((Книга.[Инвентарный №])='"+invNoObor.Text+"'));" );

                    OleDbCommand ODCommand = new OleDbCommand( queryString , db );
                    db.Open( );
                    OleDbDataReader Reader = ODCommand.ExecuteReader( );
                    if( Reader.HasRows )
                        while( Reader.Read( ) )
                        {
                            nazvOborud.Text =  Reader[ "Наименование оборудования" ].ToString();
                            //в будущем 
                            //prioritetOborud.Text = Reader[ "Категория оборудования" ].ToString();
                            prioritetOborud.Text = "2";
                        }
                    Reader.Close( );
                    db.Close( );
                }
                catch( Exception we )
                {
                    MessageBox.Show( we.Message + "\n" + we.StackTrace , "" );
                }
                

            }
        }

    }

    internal class ComboboxItem
    {
        public string Text
        {
            get; set;
        }
        public object Value
        {
            get; set;
        }
    }
}
