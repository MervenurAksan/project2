
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace IPLab
{
	
	public class SelectImageForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ListView imagesList;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Label descriptionLabel;
		
		private System.ComponentModel.Container components = null;

		
		public string Description
		{
			set { descriptionLabel.Text = value; }
		}
		
		public ArrayList ImageNames
		{
			set
			{
				imagesList.Items.Clear();

				if (value != null)
				{
					foreach (String name in value)
					{
						imagesList.Items.Add(name);
					}
				}

				okButton.Enabled = false;
			}
		}
		
		public int SelectedItem
		{
			get
			{
				return (imagesList.SelectedIndices.Count == 0) ? -1 : imagesList.SelectedIndices[0];
			}
		}


		public SelectImageForm()
		{
			
			InitializeComponent();

			
		}

		
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
	
		private void InitializeComponent()
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imagesList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.descriptionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 60);
            this.panel1.TabIndex = 0;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(10, 10);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(274, 40);
            this.descriptionLabel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 1);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // imagesList
            // 
            this.imagesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.imagesList.FullRowSelect = true;
            this.imagesList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.imagesList.Location = new System.Drawing.Point(10, 70);
            this.imagesList.MultiSelect = false;
            this.imagesList.Name = "imagesList";
            this.imagesList.Size = new System.Drawing.Size(274, 235);
            this.imagesList.TabIndex = 2;
            this.imagesList.UseCompatibleStateImageBehavior = false;
            this.imagesList.View = System.Windows.Forms.View.Details;
            this.imagesList.SelectedIndexChanged += new System.EventHandler(this.imagesList_SelectedIndexChanged);
            this.imagesList.DoubleClick += new System.EventHandler(this.imagesList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Görüntü";
            this.columnHeader1.Width = 230;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Enabled = false;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Location = new System.Drawing.Point(65, 320);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(155, 320);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            // 
            // SelectImageForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(294, 353);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.imagesList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectImageForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görüntü Seç";
            this.Load += new System.EventHandler(this.SelectImageForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		// Selection changed in list view
		private void imagesList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			okButton.Enabled = (imagesList.SelectedIndices.Count != 0);
		}

		// Double click in list view
		private void imagesList_DoubleClick(object sender, System.EventArgs e)
		{
			if (imagesList.SelectedIndices.Count != 0)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void SelectImageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
