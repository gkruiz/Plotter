using Microsoft.JScript;
using Microsoft.JScript.Vsa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUD9._9
{
    class operacion
    {


        public string EvalExpression(string expression)
        {
            VsaEngine engine = VsaEngine.CreateEngine();
            try
            {
                object o = Eval.JScriptEvaluate(expression, engine);
                return System.Convert.ToDouble(o).ToString();
            }
            catch
            {
                return "No se puede evaluar la expresión";
            }
            engine.Close();
        }
    }
}
