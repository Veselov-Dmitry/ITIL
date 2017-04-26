namespace ITIL
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.otmena = new System.Windows.Forms.Button();
            this.otchet = new System.Windows.Forms.Button();
            this.otpravit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTipZayavki = new System.Windows.Forms.Label();
            this.otdel = new System.Windows.Forms.TextBox();
            this.fio = new System.Windows.Forms.TextBox();
            this.tabNo = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.TextBox();
            this.opisanieProblemi = new System.Windows.Forms.TextBox();
            this.labelOtdel = new System.Windows.Forms.Label();
            this.labelFio = new System.Windows.Forms.Label();
            this.labelTabNo = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelInvNoObor = new System.Windows.Forms.Label();
            this.labelOpisanieProblemi = new System.Windows.Forms.Label();
            this.labelVvodSimv = new System.Windows.Forms.Label();
            this.progrPanel = new System.Windows.Forms.Panel();
            this.progrBar = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tipZayavki = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.invNoObor = new System.Windows.Forms.ComboBox();
            this.nazvOborud = new System.Windows.Forms.TextBox();
            this.Prikrepitfail = new System.Windows.Forms.TextBox();
            this.obzor = new System.Windows.Forms.Button();
            this.labelPrikrepitFail = new System.Windows.Forms.Label();
            this.panel_OASU = new System.Windows.Forms.Panel();
            this.ispolnitelLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ispolnitelList = new System.Windows.Forms.ComboBox();
            this.panel_PDS = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prioritetOborud = new System.Windows.Forms.TextBox();
            this.progrPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_OASU.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_PDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // otmena
            // 
            this.otmena.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.otmena.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.otmena.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otmena.ForeColor = System.Drawing.Color.MidnightBlue;
            this.otmena.Location = new System.Drawing.Point(46, 528);
            this.otmena.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.otmena.Name = "otmena";
            this.otmena.Size = new System.Drawing.Size(104, 41);
            this.otmena.TabIndex = 0;
            this.otmena.Text = "Отмена";
            this.otmena.UseVisualStyleBackColor = false;
            this.otmena.MouseClick += new System.Windows.Forms.MouseEventHandler(this.otmena_MouseClick);
            // 
            // otchet
            // 
            this.otchet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.otchet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.otchet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otchet.ForeColor = System.Drawing.Color.MidnightBlue;
            this.otchet.Location = new System.Drawing.Point(158, 528);
            this.otchet.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.otchet.Name = "otchet";
            this.otchet.Size = new System.Drawing.Size(82, 41);
            this.otchet.TabIndex = 1;
            this.otchet.Text = "Отчет";
            this.otchet.UseVisualStyleBackColor = false;
            this.otchet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.otchet_MouseClick);
            // 
            // otpravit
            // 
            this.otpravit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.otpravit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.otpravit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otpravit.ForeColor = System.Drawing.Color.MidnightBlue;
            this.otpravit.Location = new System.Drawing.Point(245, 528);
            this.otpravit.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.otpravit.Name = "otpravit";
            this.otpravit.Size = new System.Drawing.Size(142, 41);
            this.otpravit.TabIndex = 2;
            this.otpravit.Text = "Отправить";
            this.otpravit.UseVisualStyleBackColor = false;
            this.otpravit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.otpravit_MouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(172, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Заявка";
            this.label1.UseMnemonic = false;
            // 
            // labelTipZayavki
            // 
            this.labelTipZayavki.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTipZayavki.AutoSize = true;
            this.labelTipZayavki.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTipZayavki.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTipZayavki.Location = new System.Drawing.Point(81, 70);
            this.labelTipZayavki.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTipZayavki.Name = "labelTipZayavki";
            this.labelTipZayavki.Size = new System.Drawing.Size(89, 18);
            this.labelTipZayavki.TabIndex = 4;
            this.labelTipZayavki.Text = "Тип заявки:";
            // 
            // otdel
            // 
            this.otdel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.otdel.BackColor = System.Drawing.Color.MistyRose;
            this.otdel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otdel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.otdel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.otdel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.otdel.Location = new System.Drawing.Point(176, 110);
            this.otdel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.otdel.Name = "otdel";
            this.otdel.Size = new System.Drawing.Size(244, 26);
            this.otdel.TabIndex = 5;
            this.otdel.Enter += new System.EventHandler(this.otdel_Enter);
            this.otdel.Leave += new System.EventHandler(this.otdel_Leave);
            // 
            // fio
            // 
            this.fio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fio.BackColor = System.Drawing.Color.MistyRose;
            this.fio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.fio.Location = new System.Drawing.Point(176, 153);
            this.fio.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(244, 26);
            this.fio.TabIndex = 7;
            this.fio.Enter += new System.EventHandler(this.fio_Enter);
            this.fio.Leave += new System.EventHandler(this.fio_Leave);
            // 
            // tabNo
            // 
            this.tabNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tabNo.BackColor = System.Drawing.Color.MistyRose;
            this.tabNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tabNo.Location = new System.Drawing.Point(176, 195);
            this.tabNo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabNo.Name = "tabNo";
            this.tabNo.Size = new System.Drawing.Size(244, 26);
            this.tabNo.TabIndex = 8;
            this.tabNo.Enter += new System.EventHandler(this.tabNo_Enter);
            this.tabNo.Leave += new System.EventHandler(this.tabNo_Leave);
            // 
            // telefon
            // 
            this.telefon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.telefon.BackColor = System.Drawing.Color.MistyRose;
            this.telefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telefon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telefon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.telefon.Location = new System.Drawing.Point(176, 237);
            this.telefon.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(244, 26);
            this.telefon.TabIndex = 9;
            this.telefon.Enter += new System.EventHandler(this.telefon_Enter);
            this.telefon.Leave += new System.EventHandler(this.telefon_Leave);
            // 
            // opisanieProblemi
            // 
            this.opisanieProblemi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.opisanieProblemi.BackColor = System.Drawing.Color.MistyRose;
            this.opisanieProblemi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opisanieProblemi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.opisanieProblemi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.opisanieProblemi.Location = new System.Drawing.Point(10, 379);
            this.opisanieProblemi.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.opisanieProblemi.MaxLength = 255;
            this.opisanieProblemi.Multiline = true;
            this.opisanieProblemi.Name = "opisanieProblemi";
            this.opisanieProblemi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.opisanieProblemi.Size = new System.Drawing.Size(426, 77);
            this.opisanieProblemi.TabIndex = 11;
            this.opisanieProblemi.Enter += new System.EventHandler(this.opisanieProblemi_Enter);
            this.opisanieProblemi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.opisanieProblemi_KeyPress);
            this.opisanieProblemi.Leave += new System.EventHandler(this.opisanieProblemi_Leave);
            // 
            // labelOtdel
            // 
            this.labelOtdel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOtdel.AutoSize = true;
            this.labelOtdel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOtdel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelOtdel.Location = new System.Drawing.Point(112, 112);
            this.labelOtdel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOtdel.Name = "labelOtdel";
            this.labelOtdel.Size = new System.Drawing.Size(55, 18);
            this.labelOtdel.TabIndex = 12;
            this.labelOtdel.Text = "Отдел:";
            // 
            // labelFio
            // 
            this.labelFio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFio.AutoSize = true;
            this.labelFio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFio.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelFio.Location = new System.Drawing.Point(121, 156);
            this.labelFio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFio.Name = "labelFio";
            this.labelFio.Size = new System.Drawing.Size(47, 18);
            this.labelFio.TabIndex = 13;
            this.labelFio.Text = "ФИО:";
            // 
            // labelTabNo
            // 
            this.labelTabNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTabNo.AutoSize = true;
            this.labelTabNo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTabNo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTabNo.Location = new System.Drawing.Point(105, 200);
            this.labelTabNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTabNo.Name = "labelTabNo";
            this.labelTabNo.Size = new System.Drawing.Size(63, 18);
            this.labelTabNo.TabIndex = 14;
            this.labelTabNo.Text = "Таб. №:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTelefon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelTelefon.Location = new System.Drawing.Point(94, 245);
            this.labelTelefon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(75, 18);
            this.labelTelefon.TabIndex = 15;
            this.labelTelefon.Text = "Телефон:";
            // 
            // labelInvNoObor
            // 
            this.labelInvNoObor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelInvNoObor.AutoSize = true;
            this.labelInvNoObor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInvNoObor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelInvNoObor.Location = new System.Drawing.Point(70, 285);
            this.labelInvNoObor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInvNoObor.Name = "labelInvNoObor";
            this.labelInvNoObor.Size = new System.Drawing.Size(102, 18);
            this.labelInvNoObor.TabIndex = 16;
            this.labelInvNoObor.Text = "Инв № обор:";
            // 
            // labelOpisanieProblemi
            // 
            this.labelOpisanieProblemi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelOpisanieProblemi.AutoSize = true;
            this.labelOpisanieProblemi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpisanieProblemi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelOpisanieProblemi.Location = new System.Drawing.Point(16, 357);
            this.labelOpisanieProblemi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOpisanieProblemi.Name = "labelOpisanieProblemi";
            this.labelOpisanieProblemi.Size = new System.Drawing.Size(160, 18);
            this.labelOpisanieProblemi.TabIndex = 17;
            this.labelOpisanieProblemi.Text = "Описание проблемы:";
            // 
            // labelVvodSimv
            // 
            this.labelVvodSimv.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelVvodSimv.AutoSize = true;
            this.labelVvodSimv.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVvodSimv.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelVvodSimv.Location = new System.Drawing.Point(254, 0);
            this.labelVvodSimv.Name = "labelVvodSimv";
            this.labelVvodSimv.Size = new System.Drawing.Size(178, 14);
            this.labelVvodSimv.TabIndex = 18;
            this.labelVvodSimv.Text = "Вы ввели 0 символов (макс.255)";
            // 
            // progrPanel
            // 
            this.progrPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.progrPanel.Controls.Add(this.progrBar);
            this.progrPanel.Location = new System.Drawing.Point(178, 232);
            this.progrPanel.Name = "progrPanel";
            this.progrPanel.Size = new System.Drawing.Size(166, 41);
            this.progrPanel.TabIndex = 24;
            this.progrPanel.Visible = false;
            // 
            // progrBar
            // 
            this.progrBar.Location = new System.Drawing.Point(8, 9);
            this.progrBar.Name = "progrBar";
            this.progrBar.Size = new System.Drawing.Size(148, 23);
            this.progrBar.Step = 1;
            this.progrBar.TabIndex = 0;
            this.progrBar.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tipZayavki);
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(176, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 26);
            this.panel1.TabIndex = 27;
            // 
            // tipZayavki
            // 
            this.tipZayavki.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tipZayavki.BackColor = System.Drawing.Color.AliceBlue;
            this.tipZayavki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipZayavki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tipZayavki.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tipZayavki.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tipZayavki.FormattingEnabled = true;
            this.tipZayavki.Location = new System.Drawing.Point(-2, 0);
            this.tipZayavki.Margin = new System.Windows.Forms.Padding(0);
            this.tipZayavki.Name = "tipZayavki";
            this.tipZayavki.Size = new System.Drawing.Size(245, 26);
            this.tipZayavki.TabIndex = 27;
            this.tipZayavki.SelectedIndexChanged += new System.EventHandler(this.tipZayavki_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.invNoObor);
            this.panel2.Location = new System.Drawing.Point(176, 280);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 26);
            this.panel2.TabIndex = 28;
            // 
            // invNoObor
            // 
            this.invNoObor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.invNoObor.BackColor = System.Drawing.Color.MistyRose;
            this.invNoObor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invNoObor.Font = new System.Drawing.Font("Arial", 12F);
            this.invNoObor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.invNoObor.FormattingEnabled = true;
            this.invNoObor.Location = new System.Drawing.Point(-2, 0);
            this.invNoObor.Name = "invNoObor";
            this.invNoObor.Size = new System.Drawing.Size(245, 26);
            this.invNoObor.TabIndex = 27;
            this.invNoObor.SelectedIndexChanged += new System.EventHandler(this.invNoObor_SelectedIndexChanged);
            this.invNoObor.Enter += new System.EventHandler(this.invObor_Enter);
            this.invNoObor.Leave += new System.EventHandler(this.invObor_Leave);
            // 
            // nazvOborud
            // 
            this.nazvOborud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nazvOborud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nazvOborud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nazvOborud.Font = new System.Drawing.Font("Arial", 8F);
            this.nazvOborud.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nazvOborud.Location = new System.Drawing.Point(206, 0);
            this.nazvOborud.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nazvOborud.MaxLength = 255;
            this.nazvOborud.Name = "nazvOborud";
            this.nazvOborud.ReadOnly = true;
            this.nazvOborud.Size = new System.Drawing.Size(210, 13);
            this.nazvOborud.TabIndex = 31;
            this.nazvOborud.Text = ".";
            // 
            // Prikrepitfail
            // 
            this.Prikrepitfail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prikrepitfail.BackColor = System.Drawing.Color.Gainsboro;
            this.Prikrepitfail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Prikrepitfail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Prikrepitfail.Location = new System.Drawing.Point(7, 29);
            this.Prikrepitfail.Name = "Prikrepitfail";
            this.Prikrepitfail.Size = new System.Drawing.Size(324, 26);
            this.Prikrepitfail.TabIndex = 35;
            this.Prikrepitfail.DoubleClick += new System.EventHandler(this.obzor_Click);
            // 
            // obzor
            // 
            this.obzor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.obzor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.obzor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.obzor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.obzor.Location = new System.Drawing.Point(338, 29);
            this.obzor.Name = "obzor";
            this.obzor.Size = new System.Drawing.Size(94, 26);
            this.obzor.TabIndex = 34;
            this.obzor.Text = "Обзор...";
            this.obzor.UseVisualStyleBackColor = false;
            this.obzor.Click += new System.EventHandler(this.obzor_Click);
            // 
            // labelPrikrepitFail
            // 
            this.labelPrikrepitFail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPrikrepitFail.AutoSize = true;
            this.labelPrikrepitFail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrikrepitFail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelPrikrepitFail.Location = new System.Drawing.Point(35, 8);
            this.labelPrikrepitFail.Name = "labelPrikrepitFail";
            this.labelPrikrepitFail.Size = new System.Drawing.Size(139, 18);
            this.labelPrikrepitFail.TabIndex = 33;
            this.labelPrikrepitFail.Text = "Прикрепить файл:";
            // 
            // panel_OASU
            // 
            this.panel_OASU.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_OASU.Controls.Add(this.Prikrepitfail);
            this.panel_OASU.Controls.Add(this.labelPrikrepitFail);
            this.panel_OASU.Controls.Add(this.obzor);
            this.panel_OASU.Controls.Add(this.labelVvodSimv);
            this.panel_OASU.Location = new System.Drawing.Point(4, 457);
            this.panel_OASU.Name = "panel_OASU";
            this.panel_OASU.Size = new System.Drawing.Size(438, 63);
            this.panel_OASU.TabIndex = 3;
            // 
            // ispolnitelLabel
            // 
            this.ispolnitelLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ispolnitelLabel.AutoSize = true;
            this.ispolnitelLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ispolnitelLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ispolnitelLabel.Location = new System.Drawing.Point(63, 22);
            this.ispolnitelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ispolnitelLabel.Name = "ispolnitelLabel";
            this.ispolnitelLabel.Size = new System.Drawing.Size(105, 18);
            this.ispolnitelLabel.TabIndex = 32;
            this.ispolnitelLabel.Text = "Исполнитель:";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ispolnitelList);
            this.panel3.Location = new System.Drawing.Point(172, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 26);
            this.panel3.TabIndex = 33;
            // 
            // ispolnitelList
            // 
            this.ispolnitelList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ispolnitelList.BackColor = System.Drawing.Color.MistyRose;
            this.ispolnitelList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ispolnitelList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ispolnitelList.Font = new System.Drawing.Font("Arial", 12F);
            this.ispolnitelList.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ispolnitelList.FormattingEnabled = true;
            this.ispolnitelList.IntegralHeight = false;
            this.ispolnitelList.Items.AddRange(new object[] {
            "пусто"});
            this.ispolnitelList.Location = new System.Drawing.Point(-2, 0);
            this.ispolnitelList.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.ispolnitelList.Name = "ispolnitelList";
            this.ispolnitelList.Size = new System.Drawing.Size(245, 26);
            this.ispolnitelList.TabIndex = 27;
            this.ispolnitelList.Enter += new System.EventHandler(this.ispolnitelList_Enter);
            this.ispolnitelList.Leave += new System.EventHandler(this.ispolnitelList_Leave);
            // 
            // panel_PDS
            // 
            this.panel_PDS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_PDS.Controls.Add(this.textBox1);
            this.panel_PDS.Controls.Add(this.prioritetOborud);
            this.panel_PDS.Controls.Add(this.ispolnitelLabel);
            this.panel_PDS.Controls.Add(this.panel3);
            this.panel_PDS.Controls.Add(this.nazvOborud);
            this.panel_PDS.Location = new System.Drawing.Point(4, 305);
            this.panel_PDS.Name = "panel_PDS";
            this.panel_PDS.Size = new System.Drawing.Size(432, 49);
            this.panel_PDS.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 8F);
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(154, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.MaxLength = 255;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(27, 13);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "кат";
            // 
            // prioritetOborud
            // 
            this.prioritetOborud.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prioritetOborud.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.prioritetOborud.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prioritetOborud.Font = new System.Drawing.Font("Arial", 8F);
            this.prioritetOborud.ForeColor = System.Drawing.Color.MidnightBlue;
            this.prioritetOborud.Location = new System.Drawing.Point(182, 0);
            this.prioritetOborud.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.prioritetOborud.MaxLength = 255;
            this.prioritetOborud.Name = "prioritetOborud";
            this.prioritetOborud.ReadOnly = true;
            this.prioritetOborud.Size = new System.Drawing.Size(16, 13);
            this.prioritetOborud.TabIndex = 34;
            this.prioritetOborud.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(442, 581);
            this.Controls.Add(this.labelOpisanieProblemi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progrPanel);
            this.Controls.Add(this.labelInvNoObor);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelTabNo);
            this.Controls.Add(this.labelFio);
            this.Controls.Add(this.labelOtdel);
            this.Controls.Add(this.opisanieProblemi);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.tabNo);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.otdel);
            this.Controls.Add(this.labelTipZayavki);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otpravit);
            this.Controls.Add(this.otchet);
            this.Controls.Add(this.otmena);
            this.Controls.Add(this.panel_OASU);
            this.Controls.Add(this.panel_PDS);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 487);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявка в сервис";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.progrPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_OASU.ResumeLayout(false);
            this.panel_OASU.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel_PDS.ResumeLayout(false);
            this.panel_PDS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button otmena;
        private System.Windows.Forms.Button otchet;
        private System.Windows.Forms.Button otpravit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTipZayavki;
        private System.Windows.Forms.TextBox otdel;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.TextBox tabNo;
        private System.Windows.Forms.TextBox telefon;
        private System.Windows.Forms.TextBox opisanieProblemi;
        private System.Windows.Forms.Label labelOtdel;
        private System.Windows.Forms.Label labelFio;
        private System.Windows.Forms.Label labelTabNo;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelInvNoObor;
        private System.Windows.Forms.Label labelOpisanieProblemi;
        private System.Windows.Forms.Label labelVvodSimv;
        private System.Windows.Forms.Panel progrPanel;
        private System.Windows.Forms.ProgressBar progrBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox tipZayavki;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox invNoObor;
        private System.Windows.Forms.TextBox nazvOborud;
        private System.Windows.Forms.Label labelPrikrepitFail;
        private System.Windows.Forms.Button obzor;
        private System.Windows.Forms.TextBox Prikrepitfail;
        private System.Windows.Forms.Panel panel_OASU;
        private System.Windows.Forms.Label ispolnitelLabel;
        private System.Windows.Forms.ComboBox ispolnitelList;
        private System.Windows.Forms.Panel panel_PDS;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox prioritetOborud;
        private System.Windows.Forms.TextBox textBox1;
    }
}

