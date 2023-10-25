using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.Interfaces
{
    interface ITestBuilder
    {
        public int CreateQuestionAndGetId(QuestBuilderCreate questBuilder);
        public void CreateTest(TestBuilderCreate testCreate);
    }
}
