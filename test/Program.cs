using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    class Program
    {
        static void Main( string[] args )
        {
        }
    }
    using System;
using System.Data;
        
namespace ConnSample
    {
        public class frmConnSample : System.Windows.Forms.Form
        {
            private System.Windows.Forms.Button btnExit;
            private System.Windows.Forms.Button btnOpen;
            private System.Windows.Forms.Button btnClose;
            private System.Windows.Forms.Label lblConnState;
            private System.Windows.Forms.TextBox txtConnstate;
            private System.Data.OleDb.OleDbConnection oleDbCnn1;
            private System.Windows.Forms.Button btnShow;
            private System.Windows.Forms.ListBox lstConnProps;
            private System.ComponentModel.Container components = null;

            public frmConnSample()
            {
                InitializeComponent( );
            }


            protected override void Dispose( bool disposing
           )
            {
                if( disposing )
                {
                    if( components != null )
                    {
                        components.Dispose( );
                    }

                }
                base.Dispose( disposing );
            }

            #region Windows Form Designer generated code
            private void InitializeComponent()
            {
                this.btnExit = new
                System.Windows.Forms.Button( );
                this.oleDbCnn1 = new
                System.Data.OleDb.OleDbConnection( );
                this.btnOpen = new
                System.Windows.Forms.Button( );
                this.btnClose = new
                System.Windows.Forms.Button( );
                this.lblConnState = new
                System.Windows.Forms.Label( );
                this.txtConnstate = new
                System.Windows.Forms.TextBox( );
                this.btnShow = new
                System.Windows.Forms.Button( );
                this.lstConnProps = new
                System.Windows.Forms.ListBox( );
                this.SuspendLayout( );
                //
                // btnExit
                //
                this.btnExit.Location = new
                System.Drawing.Point( 296 , 232 );
                this.btnExit.Name = "btnExit";
                this.btnExit.TabIndex = 0;
                this.btnExit.Text = "Exit";
                this.btnExit.Click += new
                System.EventHandler( this.btnExit_Click );
                //
                // oleDbCnn1
                //
                // строка подключения; подкорректируйте ее 
                // согласно размещению файлов на вашем компьютере
                this.oleDbCnn1.ConnectionString =
               @"Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data 
            Source=C:\Program Files\Microsoft Office\Office10\Samples\Борей.mdb";
                // добавляем обработчик события StateChange
                this.oleDbCnn1.StateChange += new
                System.Data.StateChangeEventHandler( this.ShowConnState );
                //
                // btnOpen
                //
                this.btnOpen.Location = new
                System.Drawing.Point( 16 , 232 );
                this.btnOpen.Name = "btnOpen";
                this.btnOpen.TabIndex = 2;
                this.btnOpen.Text = "Open";
                this.btnOpen.Click += new
                System.EventHandler( this.btnOpen_Click );
                //
                // btnClose
                //
                this.btnClose.Location = new
                System.Drawing.Point( 104 , 232 );
                this.btnClose.Name = "btnClose";
                this.btnClose.TabIndex = 3;
                this.btnClose.Text = "Close";
                this.btnClose.Click += new
                System.EventHandler( this.btnClose_Click );
                //
                // lblConnState
                //
                this.lblConnState.Location = new
                System.Drawing.Point( 16 , 200 );
                this.lblConnState.Name = "lblConnState";
                this.lblConnState.Size = new
                System.Drawing.Size( 96 , 16 );
                this.lblConnState.TabIndex = 4;
                this.lblConnState.Text = "Connection state:";
                //
                // txtConnstate
                //
                this.txtConnstate.Location = new
                System.Drawing.Point( 112 , 200 );
                this.txtConnstate.Name = "txtConnstate";
                this.txtConnstate.TabIndex = 5;
                this.txtConnstate.Text = "";
                //
                // btnShow
                //
                this.btnShow.Location = new
                System.Drawing.Point( 296 , 200 );
                this.btnShow.Name = "btnShow";
                this.btnShow.TabIndex = 6;
                this.btnShow.Text = "Show";
                this.btnShow.Click += new
                System.EventHandler( this.btnShow_Click );
                //
                // lstConnProps
                //
                this.lstConnProps.Location = new
                System.Drawing.Point( 16 , 16 );
                this.lstConnProps.Name = "lstConnProps";
                this.lstConnProps.Size = new
                System.Drawing.Size( 344 , 173 );
                this.lstConnProps.TabIndex = 7;
                //
                // frmConnSample
                //
                this.AutoScaleBaseSize = new
                System.Drawing.Size( 5 , 13 );
                this.ClientSize = new System.Drawing.Size( 384 , 266 );
                this.Controls.AddRange( new
                System.Windows.Forms.Control[]

                {
            this.lstConnProps,
            this.btnShow,
            this.txtConnstate,
            this.lblConnState,
            this.btnClose,
            this.btnOpen,
            this.btnExit
                } );
                this.FormBorderStyle =
               System.Windows.Forms.FormBorderStyle.Fixed3D;
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.Name = "frmConnSample";
                this.Text = "Connection Sample";
                this.ResumeLayout( false );
            }
            #endregion

            [STAThread]
            static void Main()
            {
                Application.Run( new frmConnSample( ) );
            }

            private void btnExit_Click( object sender , System.EventArgs e )
            {
                Application.Exit( );
            }

            private void btnOpen_Click( object sender , System.EventArgs e )
            {
                try
                {
                    oleDbCnn1.Open( );
                }
                catch( InvalidOperationException err ) // попытка открыть уже открытое соединение
                {
                    MessageBox.Show( "Connection is already open!!!" , "Error" ,
                                                  MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
                catch( System.Data.OleDb.OleDbException err )
                {
                    MessageBox.Show( "Error opening  Connection!!!" , "Error" ,
                                                 MessageBoxButtons.OK , MessageBoxIcon.Error );
                }
            }

            private void btnClose_Click( object sender , System.EventArgs e )
            {
                oleDbCnn1.Close( );
            }

            private void btnShow_Click( object sender , System.EventArgs e )
            {
                try
                {
                    lstConnProps.Items.Clear( );
                    lstConnProps.Items.Add( "ConnectionString = " + oleDbCnn1.ConnectionString );
                    lstConnProps.Items.Add( "ConnectionTimeout = " + oleDbCnn1.ConnectionTimeout.ToString( ) );
                    lstConnProps.Items.Add( "Database = "
            + oleDbCnn1.Database );
                    lstConnProps.Items.Add( "DataSource = 
     
             " + oleDbCnn1.DataSource);
     
                    lstConnProps.Items.Add( "Provider = "
             + oleDbCnn1.Provider );

                    lstConnProps.Items.Add( "ServerVersion = " + oleDbCnn1.ServerVersion );
                    lstConnProps.Items.Add( "State = " +
             oleDbCnn1.State );
                }
                catch( System.InvalidOperationException err )
                {
                    MessageBox.Show( "Cannot get some properties of the closed Connection!!!" ,
                                                 "Warning" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
                }
            }

            // индикатор текущего состояния соединения
            private void ShowConnState( object sender , StateChangeEventArgs e )
            {
                txtConnstate.Text = oleDbCnn1.State.ToString( );
            }
        }
    }
}
