using ArxOne.MrAdvice.Advice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Aspect.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class Auth : Attribute, IMethodAdvice
    {
        public string Yetki { get; set; }
        public void Advise(MethodAdviceContext context)
        {
            //System.Windows.Forms.MessageBox.Show(Yetki);
            //var a = context.Parameters;
            //foreach (var item in a)
            //{
            //    System.Windows.Forms.MessageBox.Show(item.ToString());
            //}
        }
    }
}
