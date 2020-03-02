using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStuff
{
    public class Test : INotifyPropertyChanged
    {
        public Test()
        {
            Task.Run(async () =>
            {
                int i = 0;

                while (true)
                {
                    await Task.Delay(200);
                    Test2 = (i++).ToString();
                }

            });
        }

        public string Test1
        {
            get; set;
            /*get
            {
                return mTest;
            }
            set
            {
                if (mTest == value)
                    return;

                mTest = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Test1)));
            }*/
        }

        public string Test2 { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
