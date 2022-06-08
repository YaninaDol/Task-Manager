
namespace Task_Manager
{
    partial class ProcesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NameLB = new System.Windows.Forms.Label();
            this.CPULB = new System.Windows.Forms.Label();
            this.MemoryLB = new System.Windows.Forms.Label();
            this.DiskLB = new System.Windows.Forms.Label();
            this.WebLB = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.завершитьПроцессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снятьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.значениеРToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предоставитьОтзывToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отладкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьФайлДампаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подробноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьРасположениеФайлаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискВИнтернетеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLB.Location = new System.Drawing.Point(22, 27);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(53, 21);
            this.NameLB.TabIndex = 1;
            this.NameLB.Text = "label1";
            // 
            // CPULB
            // 
            this.CPULB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPULB.Location = new System.Drawing.Point(275, 27);
            this.CPULB.Name = "CPULB";
            this.CPULB.Size = new System.Drawing.Size(55, 30);
            this.CPULB.TabIndex = 0;
            this.CPULB.Text = "label1";
            // 
            // MemoryLB
            // 
            this.MemoryLB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryLB.Location = new System.Drawing.Point(353, 27);
            this.MemoryLB.Name = "MemoryLB";
            this.MemoryLB.Size = new System.Drawing.Size(81, 30);
            this.MemoryLB.TabIndex = 2;
            this.MemoryLB.Text = "label1";
            // 
            // DiskLB
            // 
            this.DiskLB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiskLB.Location = new System.Drawing.Point(436, 27);
            this.DiskLB.Name = "DiskLB";
            this.DiskLB.Size = new System.Drawing.Size(71, 30);
            this.DiskLB.TabIndex = 3;
            this.DiskLB.Text = "0 МБ/с";
            this.DiskLB.Click += new System.EventHandler(this.label1_Click);
            // 
            // WebLB
            // 
            this.WebLB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WebLB.Location = new System.Drawing.Point(504, 27);
            this.WebLB.Name = "WebLB";
            this.WebLB.Size = new System.Drawing.Size(70, 30);
            this.WebLB.TabIndex = 4;
            this.WebLB.Text = "0 МБ/с";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завершитьПроцессToolStripMenuItem,
            this.снятьЗадачуToolStripMenuItem,
            this.значениеРToolStripMenuItem,
            this.предоставитьОтзывToolStripMenuItem,
            this.toolStripSeparator1,
            this.отладкаToolStripMenuItem,
            this.создатьФайлДампаToolStripMenuItem,
            this.toolStripSeparator2,
            this.подробноToolStripMenuItem,
            this.открытьРасположениеФайлаToolStripMenuItem,
            this.поискВИнтернетеToolStripMenuItem,
            this.свойстваToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(292, 284);
            // 
            // завершитьПроцессToolStripMenuItem
            // 
            this.завершитьПроцессToolStripMenuItem.Name = "завершитьПроцессToolStripMenuItem";
            this.завершитьПроцессToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.завершитьПроцессToolStripMenuItem.Text = "Развернуть";
            // 
            // снятьЗадачуToolStripMenuItem
            // 
            this.снятьЗадачуToolStripMenuItem.Name = "снятьЗадачуToolStripMenuItem";
            this.снятьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.снятьЗадачуToolStripMenuItem.Text = "Снять задачу";
            this.снятьЗадачуToolStripMenuItem.Click += new System.EventHandler(this.снятьЗадачуToolStripMenuItem_Click);
            // 
            // значениеРToolStripMenuItem
            // 
            this.значениеРToolStripMenuItem.Name = "значениеРToolStripMenuItem";
            this.значениеРToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.значениеРToolStripMenuItem.Text = "Значение ресурсов";
            // 
            // предоставитьОтзывToolStripMenuItem
            // 
            this.предоставитьОтзывToolStripMenuItem.Name = "предоставитьОтзывToolStripMenuItem";
            this.предоставитьОтзывToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.предоставитьОтзывToolStripMenuItem.Text = "Предоставить отзыв";
            // 
            // отладкаToolStripMenuItem
            // 
            this.отладкаToolStripMenuItem.Name = "отладкаToolStripMenuItem";
            this.отладкаToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.отладкаToolStripMenuItem.Text = "Отладка";
            // 
            // создатьФайлДампаToolStripMenuItem
            // 
            this.создатьФайлДампаToolStripMenuItem.Name = "создатьФайлДампаToolStripMenuItem";
            this.создатьФайлДампаToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.создатьФайлДампаToolStripMenuItem.Text = "Создать файл дампа";
            // 
            // подробноToolStripMenuItem
            // 
            this.подробноToolStripMenuItem.Name = "подробноToolStripMenuItem";
            this.подробноToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.подробноToolStripMenuItem.Text = "Подробно";
            // 
            // открытьРасположениеФайлаToolStripMenuItem
            // 
            this.открытьРасположениеФайлаToolStripMenuItem.Name = "открытьРасположениеФайлаToolStripMenuItem";
            this.открытьРасположениеФайлаToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.открытьРасположениеФайлаToolStripMenuItem.Text = "Открыть расположение файла";
            // 
            // поискВИнтернетеToolStripMenuItem
            // 
            this.поискВИнтернетеToolStripMenuItem.Name = "поискВИнтернетеToolStripMenuItem";
            this.поискВИнтернетеToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.поискВИнтернетеToolStripMenuItem.Text = "Поиск в Интернете";
            // 
            // свойстваToolStripMenuItem
            // 
            this.свойстваToolStripMenuItem.Name = "свойстваToolStripMenuItem";
            this.свойстваToolStripMenuItem.Size = new System.Drawing.Size(291, 24);
            this.свойстваToolStripMenuItem.Text = "Свойства";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(288, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(288, 6);
            // 
            // ProcesControl
            // 
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.WebLB);
            this.Controls.Add(this.DiskLB);
            this.Controls.Add(this.MemoryLB);
            this.Controls.Add(this.CPULB);
            this.Controls.Add(this.NameLB);
            this.Name = "ProcesControl";
            this.Size = new System.Drawing.Size(563, 72);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label CPULB;
        private System.Windows.Forms.Label MemoryLB;
        private System.Windows.Forms.Label DiskLB;
        private System.Windows.Forms.Label WebLB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem завершитьПроцессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снятьЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem значениеРToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предоставитьОтзывToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem отладкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьФайлДампаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem подробноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьРасположениеФайлаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискВИнтернетеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойстваToolStripMenuItem;
    }
   
}
