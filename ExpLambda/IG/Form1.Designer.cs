namespace ExpLambda
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.jBCondWhere = new System.Windows.Forms.Button();
            this.jBCondSelect = new System.Windows.Forms.Button();
            this.jBCondSelectWhere = new System.Windows.Forms.Button();
            this.jBCondJoin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jBCondWhere
            // 
            this.jBCondWhere.Location = new System.Drawing.Point(54, 60);
            this.jBCondWhere.Name = "jBCondWhere";
            this.jBCondWhere.Size = new System.Drawing.Size(75, 23);
            this.jBCondWhere.TabIndex = 0;
            this.jBCondWhere.Text = "Where";
            this.jBCondWhere.UseVisualStyleBackColor = true;
            this.jBCondWhere.Click += new System.EventHandler(this.jBCondWhere_Click);
            // 
            // jBCondSelect
            // 
            this.jBCondSelect.Location = new System.Drawing.Point(165, 60);
            this.jBCondSelect.Name = "jBCondSelect";
            this.jBCondSelect.Size = new System.Drawing.Size(75, 23);
            this.jBCondSelect.TabIndex = 1;
            this.jBCondSelect.Text = "Select";
            this.jBCondSelect.UseVisualStyleBackColor = true;
            // 
            // jBCondSelectWhere
            // 
            this.jBCondSelectWhere.Location = new System.Drawing.Point(54, 136);
            this.jBCondSelectWhere.Name = "jBCondSelectWhere";
            this.jBCondSelectWhere.Size = new System.Drawing.Size(75, 23);
            this.jBCondSelectWhere.TabIndex = 2;
            this.jBCondSelectWhere.Text = "SelectWhere";
            this.jBCondSelectWhere.UseVisualStyleBackColor = true;
            // 
            // jBCondJoin
            // 
            this.jBCondJoin.Location = new System.Drawing.Point(165, 136);
            this.jBCondJoin.Name = "jBCondJoin";
            this.jBCondJoin.Size = new System.Drawing.Size(75, 23);
            this.jBCondJoin.TabIndex = 3;
            this.jBCondJoin.Text = "CondJoin";
            this.jBCondJoin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 222);
            this.Controls.Add(this.jBCondJoin);
            this.Controls.Add(this.jBCondSelectWhere);
            this.Controls.Add(this.jBCondSelect);
            this.Controls.Add(this.jBCondWhere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jBCondWhere;
        private System.Windows.Forms.Button jBCondSelect;
        private System.Windows.Forms.Button jBCondSelectWhere;
        private System.Windows.Forms.Button jBCondJoin;
    }
}

