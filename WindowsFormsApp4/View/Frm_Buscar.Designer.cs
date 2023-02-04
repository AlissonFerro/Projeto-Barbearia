namespace WindowsFormsApp4.View
{
    partial class Frm_Buscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Lst_Lista = new System.Windows.Forms.ListView();
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.Location = new System.Drawing.Point(33, 25);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Nome";
            // 
            // Lst_Lista
            // 
            this.Lst_Lista.HideSelection = false;
            this.Lst_Lista.Location = new System.Drawing.Point(36, 93);
            this.Lst_Lista.Name = "Lst_Lista";
            this.Lst_Lista.Size = new System.Drawing.Size(302, 97);
            this.Lst_Lista.TabIndex = 1;
            this.Lst_Lista.UseCompatibleStateImageBehavior = false;
            // 
            // Txt_Input
            // 
            this.Txt_Input.Location = new System.Drawing.Point(36, 41);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(100, 20);
            this.Txt_Input.TabIndex = 2;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(196, 37);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(141, 23);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Frm_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 249);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Input);
            this.Controls.Add(this.Lst_Lista);
            this.Controls.Add(this.Lbl_Name);
            this.Name = "Frm_Buscar";
            this.Text = "Frm_Buscar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.ListView Lst_Lista;
        private System.Windows.Forms.TextBox Txt_Input;
        private System.Windows.Forms.Button Btn_Buscar;
    }
}