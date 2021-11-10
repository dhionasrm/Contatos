using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Macoratti
{
	/// <summary>
	/// Resumo da descrição do formulário form1
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		MySqlConnection conMySQL = new MySqlConnection("uid=root; password=gpxpst; database=cadastro");
		MySqlCommand cmdMySQL = new MySqlCommand();
		MySqlDataReader reader;
		string status;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lstvContatos;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.TextBox txtPesquisar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAtualizar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtNome;
		public System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.Button btnLimpar;
		public System.Windows.Forms.Button btnSalvar;
		public System.Windows.Forms.Button btnFechar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button bttnDeletar;
        private PictureBox pictureBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			InitializeComponent();
            //iniicaliza a conexão MySQL
			cmdMySQL.Connection = conMySQL;
		}

		/// <summary>
		/// Libera os recursos usados no programa
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lstvContatos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttnDeletar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAtualizar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.lstvContatos);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(328, 32);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(96, 32);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar Nome:";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisar.Location = new System.Drawing.Point(135, 32);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(185, 23);
            this.txtPesquisar.TabIndex = 1;
            this.txtPesquisar.TextChanged += new System.EventHandler(this.txtPesquisar_TextChanged);
            // 
            // lstvContatos
            // 
            this.lstvContatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstvContatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstvContatos.FullRowSelect = true;
            this.lstvContatos.GridLines = true;
            this.lstvContatos.Location = new System.Drawing.Point(16, 72);
            this.lstvContatos.Name = "lstvContatos";
            this.lstvContatos.Size = new System.Drawing.Size(408, 216);
            this.lstvContatos.TabIndex = 0;
            this.lstvContatos.UseCompatibleStateImageBehavior = false;
            this.lstvContatos.View = System.Windows.Forms.View.Details;
            this.lstvContatos.SelectedIndexChanged += new System.EventHandler(this.lstvContatos_Click);
            this.lstvContatos.Click += new System.EventHandler(this.lstvContatos_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 172;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 253;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.bttnDeletar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnLimpar);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnFechar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Location = new System.Drawing.Point(456, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 304);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // bttnDeletar
            // 
            this.bttnDeletar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bttnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnDeletar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDeletar.ForeColor = System.Drawing.Color.Black;
            this.bttnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("bttnDeletar.Image")));
            this.bttnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnDeletar.Location = new System.Drawing.Point(194, 188);
            this.bttnDeletar.Name = "bttnDeletar";
            this.bttnDeletar.Size = new System.Drawing.Size(79, 34);
            this.bttnDeletar.TabIndex = 215;
            this.bttnDeletar.Text = "&Deletar ";
            this.bttnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttnDeletar.UseVisualStyleBackColor = false;
            this.bttnDeletar.Click += new System.EventHandler(this.bttnDeletar_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 40);
            this.label2.TabIndex = 214;
            this.label2.Text = "Cadastro de Contatos :  Inclui, altera e exclui informações de uma base de dados " +
                "MySQL";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(115, 188);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 34);
            this.btnLimpar.TabIndex = 212;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Control;
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(36, 188);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(79, 34);
            this.btnSalvar.TabIndex = 211;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.Control;
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFechar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.Black;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(273, 188);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(79, 34);
            this.btnFechar.TabIndex = 213;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 210;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 209;
            this.label3.Text = "Nome:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(91, 80);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmail.Size = new System.Drawing.Size(261, 71);
            this.txtEmail.TabIndex = 207;
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.Black;
            this.txtNome.Location = new System.Drawing.Point(91, 40);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(261, 23);
            this.txtNome.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 216;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.ClientSize = new System.Drawing.Size(856, 325);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Entrada principal da aplicação
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnLimpar_Click(object sender, System.EventArgs e)
		{
			txtNome.Text = "";
			txtEmail.Text = "";
			txtNome.Focus();
			status = "novo";
		}

		private void btnFechar_Click(object sender, System.EventArgs e)
		{
            if (MessageBox.Show("Deseja encerrar a aplicação?", "Encerrar",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes) 
            {
                Application.ExitThread();
            }
        }

		private void btnSalvar_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(txtNome.Text=="")
				{
					MessageBox.Show("Informe o nome do contato.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					txtNome.Focus();
				}

				else if(txtEmail.Text=="")
				{
					MessageBox.Show("Informe o email do contato.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					txtNome.Focus();
				}

				else
				{
					if(status=="novo")
					{
						cmdMySQL.CommandText = "INSERT INTO Contatos(nome,email) VALUES('"+txtNome.Text+"','"+txtEmail.Text+"')";
						cmdMySQL.ExecuteNonQuery();
						cmdMySQL.Dispose();
						MessageBox.Show("Registro salvo com sucesso.","Salvar",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}

					else if(status=="editar")
					{						
						cmdMySQL.CommandText = "UPDATE Contatos SET nome='"+txtNome.Text+"', email='"+txtEmail.Text+
							"' WHERE id='"+lstvContatos.Items[lstvContatos.FocusedItem.Index].Text+"'";
						cmdMySQL.ExecuteNonQuery();
						MessageBox.Show("Registro atualizado com sucesso.","Atualizar",MessageBoxButtons.OK,MessageBoxIcon.Information);
					}
					carregaVars();
					btnLimpar.PerformClick();
				}
			}
			catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			try
			{
				conMySQL.Open();
				status = "novo";
				carregaVars();
			}
			catch(Exception ex){MessageBox.Show(ex.ToString());}
		}

        /// <summary>
        /// CarregaVars - Preenche o controle ListView com os dados da tabela Contatos
        /// </summary>
		void carregaVars()
		{
			try
			{
				lstvContatos.Items.Clear();
				if(txtPesquisar.Text=="")
				{
                    cmdMySQL.CommandText = "SELECT * FROM Contatos ORDER BY nome ASC";
                }
				else
				{
                    cmdMySQL.CommandText = "SELECT * FROM Contatos WHERE nome LIKE '"+txtPesquisar.Text+"%' ORDER BY nome ASC";
                }
				reader = cmdMySQL.ExecuteReader();
				while(reader.Read())
				{
					ListViewItem list = new ListViewItem(reader[0].ToString());
					list.SubItems.Add(reader[1].ToString());
					list.SubItems.Add(reader[2].ToString());
					lstvContatos.Items.AddRange(new ListViewItem [] {list});
				}
				reader.Close();
			}
			catch(Exception ex){MessageBox.Show(ex.ToString());}
		}

        private void lstvContatos_Click(object sender, System.EventArgs e)
		{
			try
			{
				txtNome.Text = lstvContatos.Items[lstvContatos.FocusedItem.Index].SubItems[1].Text;
				txtEmail.Text = lstvContatos.Items[lstvContatos.FocusedItem.Index].SubItems[2].Text;
				status="editar";
			}
			catch(Exception){MessageBox.Show("Não existem registros na lista.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);}
		}

		private void bttnDeletar_Click(object sender, System.EventArgs e)
		{
            if (MessageBox.Show("Deseja encerrar a aplicação?", "Encerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    cmdMySQL.CommandText = "DELETE FROM Contatos WHERE id='" + lstvContatos.Items[lstvContatos.FocusedItem.Index].Text + "'";
                    cmdMySQL.ExecuteNonQuery();
                    MessageBox.Show("Registro deletado com sucesso.", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    carregaVars();
                    btnLimpar.PerformClick();
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
		}

		private void btnAtualizar_Click(object sender, System.EventArgs e)
		{
			txtPesquisar.Text="";
			carregaVars();
		}

		private void txtPesquisar_TextChanged(object sender, System.EventArgs e)
		{
            carregaVars();
        }
	}
}
