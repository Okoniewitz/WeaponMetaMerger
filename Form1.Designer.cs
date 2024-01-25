namespace WeaponMetaMerger
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.File1 = new System.Windows.Forms.TextBox();
            this.File2 = new System.Windows.Forms.TextBox();
            this.File3 = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.WorkSpace = new System.Windows.Forms.TextBox();
            this.File1_Name = new System.Windows.Forms.TextBox();
            this.File2_Name = new System.Windows.Forms.TextBox();
            this.Edit1 = new System.Windows.Forms.TextBox();
            this.Edit2 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.File1_Label = new System.Windows.Forms.Label();
            this.File2_Label = new System.Windows.Forms.Label();
            this.Merge = new System.Windows.Forms.Button();
            this.File4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // File1
            // 
            this.File1.Location = new System.Drawing.Point(12, 83);
            this.File1.Multiline = true;
            this.File1.Name = "File1";
            this.File1.ReadOnly = true;
            this.File1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.File1.Size = new System.Drawing.Size(462, 574);
            this.File1.TabIndex = 0;
            this.File1.WordWrap = false;
            // 
            // File2
            // 
            this.File2.Location = new System.Drawing.Point(480, 83);
            this.File2.Multiline = true;
            this.File2.Name = "File2";
            this.File2.ReadOnly = true;
            this.File2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.File2.Size = new System.Drawing.Size(469, 574);
            this.File2.TabIndex = 1;
            this.File2.WordWrap = false;
            // 
            // File3
            // 
            this.File3.Location = new System.Drawing.Point(955, 83);
            this.File3.Multiline = true;
            this.File3.Name = "File3";
            this.File3.ReadOnly = true;
            this.File3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.File3.Size = new System.Drawing.Size(453, 574);
            this.File3.TabIndex = 2;
            this.File3.WordWrap = false;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(1443, 81);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // WorkSpace
            // 
            this.WorkSpace.Location = new System.Drawing.Point(1455, 123);
            this.WorkSpace.Name = "WorkSpace";
            this.WorkSpace.Size = new System.Drawing.Size(100, 20);
            this.WorkSpace.TabIndex = 4;
            this.WorkSpace.Text = "F:\\SteamLibrary\\steamapps\\common\\Grand Theft Auto V\\scripts\\Pickups & Real shit\\u" +
    "pdaterpf\\common\\data\\ai";
            // 
            // File1_Name
            // 
            this.File1_Name.Location = new System.Drawing.Point(1455, 172);
            this.File1_Name.Name = "File1_Name";
            this.File1_Name.Size = new System.Drawing.Size(100, 20);
            this.File1_Name.TabIndex = 5;
            this.File1_Name.Text = "pick";
            // 
            // File2_Name
            // 
            this.File2_Name.Location = new System.Drawing.Point(1455, 198);
            this.File2_Name.Name = "File2_Name";
            this.File2_Name.Size = new System.Drawing.Size(100, 20);
            this.File2_Name.TabIndex = 6;
            this.File2_Name.Text = "ripp";
            // 
            // Edit1
            // 
            this.Edit1.Location = new System.Drawing.Point(1455, 350);
            this.Edit1.Name = "Edit1";
            this.Edit1.Size = new System.Drawing.Size(100, 20);
            this.Edit1.TabIndex = 7;
            this.Edit1.Text = "<Fx>";
            // 
            // Edit2
            // 
            this.Edit2.Location = new System.Drawing.Point(1455, 376);
            this.Edit2.Name = "Edit2";
            this.Edit2.Size = new System.Drawing.Size(100, 20);
            this.Edit2.TabIndex = 8;
            this.Edit2.Text = "<AttachPoints>";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(1443, 463);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // File1_Label
            // 
            this.File1_Label.AutoSize = true;
            this.File1_Label.Location = new System.Drawing.Point(59, 9);
            this.File1_Label.Name = "File1_Label";
            this.File1_Label.Size = new System.Drawing.Size(35, 13);
            this.File1_Label.TabIndex = 12;
            this.File1_Label.Text = "label1";
            // 
            // File2_Label
            // 
            this.File2_Label.AutoSize = true;
            this.File2_Label.Location = new System.Drawing.Point(59, 34);
            this.File2_Label.Name = "File2_Label";
            this.File2_Label.Size = new System.Drawing.Size(35, 13);
            this.File2_Label.TabIndex = 13;
            this.File2_Label.Text = "label1";
            // 
            // Merge
            // 
            this.Merge.Location = new System.Drawing.Point(1443, 308);
            this.Merge.Name = "Merge";
            this.Merge.Size = new System.Drawing.Size(75, 23);
            this.Merge.TabIndex = 14;
            this.Merge.Text = "Merge";
            this.Merge.UseVisualStyleBackColor = true;
            this.Merge.Click += new System.EventHandler(this.Merge_Click);
            // 
            // File4
            // 
            this.File4.Location = new System.Drawing.Point(27, 642);
            this.File4.Multiline = true;
            this.File4.Name = "File4";
            this.File4.ReadOnly = true;
            this.File4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.File4.Size = new System.Drawing.Size(48, 63);
            this.File4.TabIndex = 15;
            this.File4.Visible = false;
            this.File4.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1581, 704);
            this.Controls.Add(this.File4);
            this.Controls.Add(this.Merge);
            this.Controls.Add(this.File2_Label);
            this.Controls.Add(this.File1_Label);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Edit2);
            this.Controls.Add(this.Edit1);
            this.Controls.Add(this.File2_Name);
            this.Controls.Add(this.File1_Name);
            this.Controls.Add(this.WorkSpace);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.File3);
            this.Controls.Add(this.File2);
            this.Controls.Add(this.File1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox File1;
        private System.Windows.Forms.TextBox File2;
        private System.Windows.Forms.TextBox File3;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox WorkSpace;
        private System.Windows.Forms.TextBox File1_Name;
        private System.Windows.Forms.TextBox File2_Name;
        private System.Windows.Forms.TextBox Edit1;
        private System.Windows.Forms.TextBox Edit2;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label File1_Label;
        private System.Windows.Forms.Label File2_Label;
        private System.Windows.Forms.Button Merge;
        private System.Windows.Forms.TextBox File4;
    }
}

