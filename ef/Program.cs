using EF.Services;

//TeacherService teacherService = new TeacherService();
//teacherService.HeadTeachersName();
//teacherService.HeadTeachersLambda();
//teacherService.WomanTeacher();
//teacherService.WomanTeacherLambda();
//teacherService.WomanTeacherIndex();
//teacherService.WomanTeacherIndexLambda();

//AddressService addressService = new AddressService();
//addressService.TeacherAndAddress();
//addressService.StudentAndAddress();

//OneManyStudentOfClassService studentOfClassService= new OneManyStudentOfClassService();
//studentOfClassService.StudentWithClass();
//studentOfClassService.StudentOfClass();


//TeachTeacherSubjectService teachTeacherSubjectService = new TeachTeacherSubjectService();
//teachTeacherSubjectService.TeacherSubjectPair();
//teachTeacherSubjectService.TeacherSubjectPairLinq();
//teachTeacherSubjectService.TeacherTeachSubjects();
//teachTeacherSubjectService.NumberOfTeacherPerSubject();

ManyManyTeachTeacherSubjectService tts = new ManyManyTeachTeacherSubjectService();
tts.TeacherSubjectPair();

Console.ReadKey();