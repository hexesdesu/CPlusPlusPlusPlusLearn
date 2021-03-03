using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            Work emergencyProject = new Work();
            emergencyProject.Hour = 9;
            emergencyProject.WriteProgram();
            emergencyProject.Hour = 10;
            emergencyProject.WriteProgram();
            emergencyProject.Hour = 12;
            emergencyProject.WriteProgram();
            emergencyProject.Hour = 13;
            emergencyProject.WriteProgram();
            emergencyProject.Hour = 14;
            emergencyProject.WriteProgram();
            emergencyProject.Hour = 17;
            emergencyProject.WriteProgram();

            emergencyProject.TaskFinished = false;

            emergencyProject.WriteProgram();
            emergencyProject.Hour = 19;
            emergencyProject.WriteProgram();
            emergencyProject.Hour = 22;
            emergencyProject.WriteProgram();

            Console.Read();
        }
    }
}
