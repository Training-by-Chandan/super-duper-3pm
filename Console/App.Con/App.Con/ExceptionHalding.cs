using System;
using System.IO;
using System.Text;

namespace App.Con
{
    public class ExceptionHalding
    {
        public int Add(int a, int b)
        {
            if (a == 0)
            {
                throw new NotSupportedException("0 is not supported");
            }
            if (a % 5 == 0)
            {
                throw new MultipleOf5Exception("You cannot pass the number multiple of 5");
            }
            return a + b;
        }
    }

    [Serializable]
    public class MultipleOf5Exception : Exception
    {
        public MultipleOf5Exception()
        {
            LogText();
        }

        public MultipleOf5Exception(string message) : base(message)
        {
            LogText();
        }

        public MultipleOf5Exception(string message, Exception inner) : base(message, inner)
        {
            LogText();
        }

        protected MultipleOf5Exception(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context)
        {
            LogText();
        }

        private void LogText()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=========================================");
            sb.AppendLine($"Date :  {DateTime.Now}");
            sb.AppendLine(this.Message);
            sb.AppendLine("------------------------------------------");
            System.Diagnostics.StackTrace st = new System.Diagnostics.StackTrace(2,true);
            sb.AppendLine(st.ToString());
            sb.AppendLine("=========================================\n\n");
            File.AppendAllText("log.txt", sb.ToString());
        }
    }
}