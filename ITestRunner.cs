using System;
using System.Collections.Generic;
using System.Text;

namespace QATest
{ 
    public interface ITestRunner
    {
        void RunTests(TestSuite suite);
    }
}
