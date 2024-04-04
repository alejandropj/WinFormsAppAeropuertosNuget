namespace WinFormsAppAeropuertosNuget
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoad = new Button();
            label1 = new Label();
            listAeropuertos = new ListBox();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(23, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(139, 28);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Cargar aeropuertos";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 53);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Aeropuertos";
            // 
            // listAeropuertos
            // 
            listAeropuertos.FormattingEnabled = true;
            listAeropuertos.ItemHeight = 15;
            listAeropuertos.Location = new Point(23, 82);
            listAeropuertos.Name = "listAeropuertos";
            listAeropuertos.Size = new Size(139, 169);
            listAeropuertos.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(190, 282);
            Controls.Add(listAeropuertos);
            Controls.Add(label1);
            Controls.Add(btnLoad);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private Label label1;
        private ListBox listAeropuertos;
    }
}
