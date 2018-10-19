namespace IPLab
{
    partial class ImageDoc
    {
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem filtersItem;
        private System.Windows.Forms.MenuItem grayscaleColorFiltersItem;
        private System.Windows.Forms.MenuItem colorFiltersItem;
        private System.Windows.Forms.MenuItem binaryFiltersItem;
        private System.Windows.Forms.MenuItem thresholdBinaryFiltersItem;
        private System.Windows.Forms.MenuItem morphologyFiltersItem;
        private System.Windows.Forms.MenuItem convolutionFiltersItem;
        private System.Windows.Forms.MenuItem meanConvolutionFiltersItem;
        private System.Windows.Forms.MenuItem medianFiltersItem;
        private System.Windows.Forms.MenuItem erosionMorphologyFiltersItem;
        private System.Windows.Forms.MenuItem redColorFiltersItem;
        private System.Windows.Forms.MenuItem greenColorFiltersItem;
        private System.Windows.Forms.MenuItem blueColorFiltersItem;
        private System.Windows.Forms.MenuItem menuItem17;
        private System.Windows.Forms.MenuItem menuItem24;
        private System.Windows.Forms.MenuItem brightnessHslFiltersItem;
        private System.Windows.Forms.MenuItem contrastHslFiltersItem;
        private System.Windows.Forms.MenuItem fourierFiltersItem;
        private System.Windows.Forms.MenuItem edgeFiltersItem;
        private System.Windows.Forms.MenuItem differenceEdgeFiltersItem;
        private System.Windows.Forms.MenuItem sobelEdgeFiltersItem;
        private System.Windows.Forms.MenuItem gaussianConvolutionFiltersItem;
        private System.Windows.Forms.MenuItem noiseFiltersItem;
        private System.Windows.Forms.MenuItem additiveNoiseFiltersItem;
        private System.Windows.Forms.MenuItem saltNoiseFiltersItem;
        private System.Windows.Forms.MenuItem menuItem35;
        private System.Windows.Forms.MenuItem susanCornersDetectorMenuItem;
        private System.Windows.Forms.MenuItem moravecCornersDetectorMenuItem;
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if ( disposing )
            {
                if ( components != null )
                {
                    components.Dispose( );
                }
                if ( image != null )
                {
                    image.Dispose( );
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.filtersItem = new System.Windows.Forms.MenuItem();
            this.colorFiltersItem = new System.Windows.Forms.MenuItem();
            this.grayscaleColorFiltersItem = new System.Windows.Forms.MenuItem();
            this.brightnessHslFiltersItem = new System.Windows.Forms.MenuItem();
            this.contrastHslFiltersItem = new System.Windows.Forms.MenuItem();
            this.redColorFiltersItem = new System.Windows.Forms.MenuItem();
            this.greenColorFiltersItem = new System.Windows.Forms.MenuItem();
            this.blueColorFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem17 = new System.Windows.Forms.MenuItem();
            this.binaryFiltersItem = new System.Windows.Forms.MenuItem();
            this.thresholdBinaryFiltersItem = new System.Windows.Forms.MenuItem();
            this.morphologyFiltersItem = new System.Windows.Forms.MenuItem();
            this.erosionMorphologyFiltersItem = new System.Windows.Forms.MenuItem();
            this.convolutionFiltersItem = new System.Windows.Forms.MenuItem();
            this.meanConvolutionFiltersItem = new System.Windows.Forms.MenuItem();
            this.gaussianConvolutionFiltersItem = new System.Windows.Forms.MenuItem();
            this.edgeFiltersItem = new System.Windows.Forms.MenuItem();
            this.differenceEdgeFiltersItem = new System.Windows.Forms.MenuItem();
            this.sobelEdgeFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem35 = new System.Windows.Forms.MenuItem();
            this.susanCornersDetectorMenuItem = new System.Windows.Forms.MenuItem();
            this.moravecCornersDetectorMenuItem = new System.Windows.Forms.MenuItem();
            this.noiseFiltersItem = new System.Windows.Forms.MenuItem();
            this.additiveNoiseFiltersItem = new System.Windows.Forms.MenuItem();
            this.saltNoiseFiltersItem = new System.Windows.Forms.MenuItem();
            this.menuItem24 = new System.Windows.Forms.MenuItem();
            this.medianFiltersItem = new System.Windows.Forms.MenuItem();
            this.fourierFiltersItem = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.filtersItem});
            // 
            // filtersItem
            // 
            this.filtersItem.Index = 0;
            this.filtersItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.colorFiltersItem,
            this.binaryFiltersItem,
            this.morphologyFiltersItem,
            this.convolutionFiltersItem,
            this.edgeFiltersItem,
            this.menuItem35,
            this.noiseFiltersItem,
            this.menuItem24,
            this.fourierFiltersItem});
            this.filtersItem.MergeOrder = 1;
            this.filtersItem.Text = "Filtreler";
            // 
            // colorFiltersItem
            // 
            this.colorFiltersItem.Index = 0;
            this.colorFiltersItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.grayscaleColorFiltersItem,
            this.brightnessHslFiltersItem,
            this.contrastHslFiltersItem,
            this.redColorFiltersItem,
            this.greenColorFiltersItem,
            this.blueColorFiltersItem,
            this.menuItem17});
            this.colorFiltersItem.Text = "&Renk (RGB)";
            // 
            // grayscaleColorFiltersItem
            // 
            this.grayscaleColorFiltersItem.Index = 0;
            this.grayscaleColorFiltersItem.Text = "&Gri Görüntü";
            this.grayscaleColorFiltersItem.Click += new System.EventHandler(this.grayscaleColorFiltersItem_Click);
            // 
            // brightnessHslFiltersItem
            // 
            this.brightnessHslFiltersItem.Index = 1;
            this.brightnessHslFiltersItem.Text = "&Parlaklýk";
            this.brightnessHslFiltersItem.Click += new System.EventHandler(this.brightnessHslFiltersItem_Click);
            // 
            // contrastHslFiltersItem
            // 
            this.contrastHslFiltersItem.Index = 2;
            this.contrastHslFiltersItem.Text = "&Kontrast";
            this.contrastHslFiltersItem.Click += new System.EventHandler(this.contrastHslFiltersItem_Click);
            // 
            // redColorFiltersItem
            // 
            this.redColorFiltersItem.Index = 3;
            this.redColorFiltersItem.Text = "Kýrmýzý";
            this.redColorFiltersItem.Click += new System.EventHandler(this.redColorFiltersItem_Click);
            // 
            // greenColorFiltersItem
            // 
            this.greenColorFiltersItem.Index = 4;
            this.greenColorFiltersItem.Text = "Yeþil";
            this.greenColorFiltersItem.Click += new System.EventHandler(this.greenColorFiltersItem_Click);
            // 
            // blueColorFiltersItem
            // 
            this.blueColorFiltersItem.Index = 5;
            this.blueColorFiltersItem.Text = "Mavi";
            this.blueColorFiltersItem.Click += new System.EventHandler(this.blueColorFiltersItem_Click);
            // 
            // menuItem17
            // 
            this.menuItem17.Index = 6;
            this.menuItem17.Text = "-";
            // 
            // binaryFiltersItem
            // 
            this.binaryFiltersItem.Index = 1;
            this.binaryFiltersItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.thresholdBinaryFiltersItem});
            this.binaryFiltersItem.Text = "&Binarization";
            // 
            // thresholdBinaryFiltersItem
            // 
            this.thresholdBinaryFiltersItem.Index = 0;
            this.thresholdBinaryFiltersItem.Text = "&Threshold";
            this.thresholdBinaryFiltersItem.Click += new System.EventHandler(this.thresholdBinaryFiltersItem_Click);
            // 
            // morphologyFiltersItem
            // 
            this.morphologyFiltersItem.Index = 2;
            this.morphologyFiltersItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.erosionMorphologyFiltersItem});
            this.morphologyFiltersItem.Text = "&Morfoloji";
            // 
            // erosionMorphologyFiltersItem
            // 
            this.erosionMorphologyFiltersItem.Index = 0;
            this.erosionMorphologyFiltersItem.Text = "&Erosion";
            this.erosionMorphologyFiltersItem.Click += new System.EventHandler(this.erosionMorphologyFiltersItem_Click);
            // 
            // convolutionFiltersItem
            // 
            this.convolutionFiltersItem.Index = 3;
            this.convolutionFiltersItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.meanConvolutionFiltersItem,
            this.gaussianConvolutionFiltersItem});
            this.convolutionFiltersItem.Text = "Konvalsiyon && Korelasyon";
            // 
            // meanConvolutionFiltersItem
            // 
            this.meanConvolutionFiltersItem.Index = 0;
            this.meanConvolutionFiltersItem.Text = "&Mean";
            this.meanConvolutionFiltersItem.Click += new System.EventHandler(this.meanConvolutionFiltersItem_Click);
            // 
            // gaussianConvolutionFiltersItem
            // 
            this.gaussianConvolutionFiltersItem.Index = 1;
            this.gaussianConvolutionFiltersItem.Text = "&Gauss";
            this.gaussianConvolutionFiltersItem.Click += new System.EventHandler(this.gaussianConvolutionFiltersItem_Click);
            // 
            // edgeFiltersItem
            // 
            this.edgeFiltersItem.Index = 4;
            this.edgeFiltersItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.differenceEdgeFiltersItem,
            this.sobelEdgeFiltersItem});
            this.edgeFiltersItem.Text = "&Kenar Bulma";
            // 
            // differenceEdgeFiltersItem
            // 
            this.differenceEdgeFiltersItem.Index = 0;
            this.differenceEdgeFiltersItem.Text = "&Farklarý";
            this.differenceEdgeFiltersItem.Click += new System.EventHandler(this.differenceEdgeFiltersItem_Click);
            // 
            // sobelEdgeFiltersItem
            // 
            this.sobelEdgeFiltersItem.Index = 1;
            this.sobelEdgeFiltersItem.Text = "&Sobel";
            this.sobelEdgeFiltersItem.Click += new System.EventHandler(this.sobelEdgeFiltersItem_Click);
            // 
            // menuItem35
            // 
            this.menuItem35.Index = 5;
            this.menuItem35.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.susanCornersDetectorMenuItem,
            this.moravecCornersDetectorMenuItem});
            this.menuItem35.Text = "Köþe Bulma";
            // 
            // susanCornersDetectorMenuItem
            // 
            this.susanCornersDetectorMenuItem.Index = 0;
            this.susanCornersDetectorMenuItem.Text = "SUSAN";
            this.susanCornersDetectorMenuItem.Click += new System.EventHandler(this.susanCornersDetectorMenuItem_Click);
            // 
            // moravecCornersDetectorMenuItem
            // 
            this.moravecCornersDetectorMenuItem.Index = 1;
            this.moravecCornersDetectorMenuItem.Text = "Moravec";
            this.moravecCornersDetectorMenuItem.Click += new System.EventHandler(this.moravecCornersDetectorMenuItem_Click);
            // 
            // noiseFiltersItem
            // 
            this.noiseFiltersItem.Index = 6;
            this.noiseFiltersItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.additiveNoiseFiltersItem,
            this.saltNoiseFiltersItem});
            this.noiseFiltersItem.Text = "&Gürültü";
            // 
            // additiveNoiseFiltersItem
            // 
            this.additiveNoiseFiltersItem.Index = 0;
            this.additiveNoiseFiltersItem.Text = "&Additive";
            this.additiveNoiseFiltersItem.Click += new System.EventHandler(this.additiveNoiseFiltersItem_Click);
            // 
            // saltNoiseFiltersItem
            // 
            this.saltNoiseFiltersItem.Index = 1;
            this.saltNoiseFiltersItem.Text = "&Tuz ve Biber";
            this.saltNoiseFiltersItem.Click += new System.EventHandler(this.saltNoiseFiltersItem_Click);
            // 
            // menuItem24
            // 
            this.menuItem24.Index = 7;
            this.menuItem24.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.medianFiltersItem});
            this.menuItem24.Text = "Diðerleri";
            // 
            // medianFiltersItem
            // 
            this.medianFiltersItem.Index = 0;
            this.medianFiltersItem.Text = "Me&dian";
            this.medianFiltersItem.Click += new System.EventHandler(this.medianFiltersItem_Click);
            // 
            // fourierFiltersItem
            // 
            this.fourierFiltersItem.Index = 8;
            this.fourierFiltersItem.Text = "&Fourier Dönüsümü";
            this.fourierFiltersItem.Click += new System.EventHandler(this.fourierFiltersItem_Click);
            // 
            // ImageDoc
            // 
            this.AllowedStates = WeifenLuo.WinFormsUI.ContentStates.Document;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(528, 417);
            this.Menu = this.mainMenu;
            this.Name = "ImageDoc";
            this.Text = "Görüntü";
            this.Load += new System.EventHandler(this.ImageDoc_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImageDoc_MouseDown);
            this.MouseLeave += new System.EventHandler(this.ImageDoc_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImageDoc_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImageDoc_MouseUp);
            this.ResumeLayout(false);

        }
        #endregion    
    }
}