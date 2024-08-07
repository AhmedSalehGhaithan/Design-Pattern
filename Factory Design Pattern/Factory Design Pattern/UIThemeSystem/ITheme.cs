using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Design_Pattern.UIThemeSystem
{
    public interface ITheme
    {
        string BackgroundColor { get; }
        string TextColor { get; }
        void ApplyTheme();
    }
}
