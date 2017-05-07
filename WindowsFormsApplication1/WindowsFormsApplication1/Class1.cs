using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Drawing;

namespace System.Windows.Forms
{
    public class PlaceHolderTextBox : MaskedTextBox
    {

        bool isPlaceHolder = true;
        string savedMask = null;      
        
        string _placeHolderText;
        public string PlaceHolderText
        {
            get { return _placeHolderText; }
            set
            {
                _placeHolderText = value;
                setPlaceholder();
            }
        }
               
        private void setPlaceholder()
        {

            if (!string.IsNullOrEmpty(this.Mask))
            {
                this.savedMask = this.Mask;
                this.Mask = "";
            }

            if (string.IsNullOrEmpty(this.Text))
            {             
                this.Text = PlaceHolderText;               
                this.ForeColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Italic);
                isPlaceHolder = true;
            } else
            {
                this.Mask = this.savedMask;
            }
        }
      
        private void removePlaceHolder()
        {
            
            if (isPlaceHolder)
            {
                this.Text = "";
                this.Mask = this.savedMask;                
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolder = false;
            } else
            {
                this.Mask = this.savedMask;
            }
        }

        public PlaceHolderTextBox()
        {            
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;            
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            setPlaceholder();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            removePlaceHolder();
        }     
    }
}
