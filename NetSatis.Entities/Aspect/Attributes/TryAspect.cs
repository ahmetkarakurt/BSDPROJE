using ArxOne.MrAdvice.Advice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDPROJE.Entities.Aspect.Attributes
{
    public class TryAspect : Attribute, IMethodAdvice
    {

        public void Advise(MethodAdviceContext context)
        {
            try
            {
               

                context.Proceed();
            }
            catch (NullReferenceException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            { System.Windows.Forms.MessageBox.Show(ex.Message); }
            catch (ObjectDisposedException ex )
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);


             }

            
           

        }
    }
}
