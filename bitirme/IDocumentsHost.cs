
namespace IPLab
{
	using System;
	using System.Drawing;
	using System.Drawing.Imaging;

	using AForge.Imaging;

	public interface IDocumentsHost
	{
		bool CreateNewDocumentOnChange{get;}
		bool RememberOnChange{get;}

		bool NewDocument(Bitmap image);
		bool NewDocument(ComplexImage image);

		Bitmap GetImage(object sender, String text, Size size, PixelFormat format);
	}
}
