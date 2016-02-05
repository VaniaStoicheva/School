using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MobillPhon_14
{
    static class StudentTest
    {
        private static Student testWithOneArgument;
        private static Student testWithFourArguments;
        private static Student testWithThreeArguments;
        private static Student testWithAllArguments;

        static StudentTest()
        {
            testWithOneArgument = new Student("Joro");
            testWithThreeArguments = new Student("Iva", "gfd@abv.bg", 089765);
            testWithFourArguments = new Student("Ema", 3, Speciality.IT,University.TU);
            testWithAllArguments = new Student("Pepi", 2, Speciality.Matematika, University.PU, "ert@asd.gf", 01245);
        }

        public static void PrintTest()
        {
            Console.WriteLine(testWithOneArgument.StudentInfo());
            Console.WriteLine(testWithThreeArguments.StudentInfo());
            Console.WriteLine(testWithFourArguments.StudentInfo());
            Console.WriteLine(testWithAllArguments.StudentInfo());
        }
    }
}
