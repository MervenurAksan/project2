// Image Processing Lab
//
// Copyright © Andrew Kirillov, 2005-2009
// andrew.kirillov@aforgenet.com
//

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;
using AForge.Imaging.Filters;

namespace IPLab
{
    /// <summary>
    /// FilterPreview window
    /// </summary>
    public class FilterPreview : System.Windows.Forms.Control
    {
        private Bitmap previewImage;
        private Bitmap image;
        private IFilter filter;
        private Pen blackPen = new Pen( Color.Black, 1 );
       

        
       
     

        private int startTrackingX, startTrackingY;
        private int oldImageX, oldImageY;

        // Image property
        [Browsable( false )]
        public Bitmap Image
        {
            get { return image; }
            set
            {
                image = value;

                if ( value != null )
                {
                    // calculate size of preview area
                    

                    // calculate image position
                  
                }

                RefreshFilter( );
            }
        }
        // Filter property
        [Browsable( false )]
        public AForge.Imaging.Filters.IFilter Filter
        {
            set
            {
                filter = value;
                RefreshFilter( );
            }
        }

        // Constructor
        public FilterPreview( )
        {
            InitializeComponent( );
            SetStyle( ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw |
                ControlStyles.DoubleBuffer | ControlStyles.UserPaint, true );


            // load cursors
            Assembly assembly = this.GetType( ).Assembly;
           
        }

        // Dispose
        protected override void Dispose( bool disposing )
        {
            if ( disposing )
            {
                blackPen.Dispose( );

                if ( previewImage != null )
                {
                    previewImage.Dispose( );
                   
                }
            }
            base.Dispose( disposing );
        }

        // Initialize control
        private void InitializeComponent( )
        {
            this.MouseUp += new System.Windows.Forms.MouseEventHandler( this.FilterPreview_MouseUp );
            this.MouseMove += new System.Windows.Forms.MouseEventHandler( this.FilterPreview_MouseMove );
            this.MouseDown += new System.Windows.Forms.MouseEventHandler( this.FilterPreview_MouseDown );
        }

        // Paint control
        protected override void OnPaint( PaintEventArgs pe )
        {
            Graphics g = pe.Graphics;
            Rectangle rc = ClientRectangle;
            int width = rc.Width;
            int height = rc.Height;
            int x, y;

            // calculate size of preview area
            if ( image != null )
            {
               
            }
            // calculate position of preview area
            x = ( rc.Width - width ) >> 1;
            y = ( rc.Height - height ) >> 1;

            // draw rectangle
            g.DrawRectangle( blackPen, x, y, width - 1, height - 1 );

            x++;
            y++;

            if ( image != null )
            {
                if ( previewImage == null )
                {
                    // draw original image
                   
                }
                else
                {
                    // draw preview image
                    
                }
            }

            // Calling the base class OnPaint
            base.OnPaint( pe );
        }

        // Refresh preview
        public void RefreshFilter( )
        {
            // release old image
            if ( previewImage != null )
            {
                previewImage.Dispose( );
                previewImage = null;
            }

            if ( ( image != null ) && ( filter != null ) )
            {
                Bitmap originalOverlayImage = null;
                Bitmap tempOverlayImage = null;

                // if the filter uses overlay image, then crop it also
                if ( filter is BaseInPlaceFilter2 )
                {
                    BaseInPlaceFilter2 filter2 = (BaseInPlaceFilter2) filter;

                    originalOverlayImage = filter2.OverlayImage;
                    
                    filter2.OverlayImage = tempOverlayImage;
                }
                else if ( filter is BaseFilter2 )
                {
                    BaseFilter2 filter2 = (BaseFilter2) filter;

                    originalOverlayImage = filter2.OverlayImage;
                   
                    filter2.OverlayImage = tempOverlayImage;
                }

                

                try
                {
                   
                }
                catch ( Exception )
                {
                }

                // restore overlay image
                if ( originalOverlayImage != null )
                {
                    if ( filter is BaseInPlaceFilter2 )
                    {
                        ( (BaseInPlaceFilter2) filter ).OverlayImage = originalOverlayImage;
                    }
                    else if ( filter is BaseFilter2 )
                    {
                        ( (BaseFilter2) filter ).OverlayImage = originalOverlayImage;
                    }
                }

                if ( tempOverlayImage != null )
                {
                    tempOverlayImage.Dispose( );
                }

                // release temp image
                
            }

            // repaint
            Invalidate( );
        }

        // On mouse move
        private void FilterPreview_MouseMove( object sender, System.Windows.Forms.MouseEventArgs e )
        {
           
        }

        // On mouse button down
        private void FilterPreview_MouseDown( object sender, System.Windows.Forms.MouseEventArgs e )
        {
            if ( ( image != null ) && ( e.Button == MouseButtons.Left ) )
            {
                // start tracking
               
                Capture = true;

                startTrackingX = e.X;
                startTrackingY = e.Y;

               

                // release preview image
                if ( previewImage != null )
                {
                    previewImage.Dispose( );
                    previewImage = null;
                }
                // repaint
                Invalidate( );

                // set cursor
              
            }
        }

        // On mouse button up
        private void FilterPreview_MouseUp( object sender, System.Windows.Forms.MouseEventArgs e )
        {
           
        }
    }
}
