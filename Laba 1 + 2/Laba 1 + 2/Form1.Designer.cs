namespace Laba_1___2
{
     partial class fMain
     {
          /// <summary>
          /// Обязательная переменная конструктора.
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
          /// Требуемый метод для поддержки конструктора — не изменяйте 
          /// содержимое этого метода с помощью редактора кода.
          /// </summary>
          private void InitializeComponent()
          {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
               this.SuspendLayout();
               // 
               // fMain
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(622, 521);
               this.Cursor = System.Windows.Forms.Cursors.Default;
               this.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
               this.HelpButton = true;
               this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "fMain";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Sketcher";
               this.ResumeLayout(false);

          }

          #endregion
     }
}

