namespace SistemaGestióndeEstudiantesCursos
{
    class Program
    {
        public static void Main()
        {
            // ===== CURSOS =====
            Curso curso1 = new Curso("POO101", "Programación Orientada a Objetos", 4);
            Curso curso2 = new Curso("BD102", "Base de Datos", 3);
            Curso curso3 = new Curso("WEB103", "Desarrollo Web", 4);
            Curso curso4 = new Curso("ALG104", "Algoritmos y Estructuras", 5);
            Curso curso5 = new Curso("RED105", "Redes de Computadoras", 3);
            Curso curso6 = new Curso("SO106", "Sistemas Operativos", 4);
            Curso curso7 = new Curso("IA107", "Introducción a la IA", 4);
            Curso curso8 = new Curso("SEC108", "Seguridad Informática", 3);
            Curso curso9 = new Curso("MOV109", "Desarrollo Móvil", 4);
            Curso curso10 = new Curso("ARQ110", "Arquitectura de Computadores", 5);

            // ===== ESTUDIANTES =====
            Estudiante est1 = new Estudiante("2022-001", "Carlos", "Martínez", 18);
            Estudiante est2 = new Estudiante("2022-002", "Ana", "López", 19);
            Estudiante est3 = new Estudiante("2022-003", "Pedro", "Gómez", 20);
            Estudiante est4 = new Estudiante("2022-004", "Laura", "Pérez", 18);
            Estudiante est5 = new Estudiante("2022-005", "Javier", "Rodríguez", 21);
            Estudiante est6 = new Estudiante("2022-006", "María", "Fernández", 22);
            Estudiante est7 = new Estudiante("2022-007", "Luis", "Ramírez", 20);
            Estudiante est8 = new Estudiante("2022-008", "Sofía", "Torres", 19);
            Estudiante est9 = new Estudiante("2022-009", "Andrés", "Morales", 18);
            Estudiante est10 = new Estudiante("2022-010", "Valentina", "Jiménez", 19);

            // ===== INSCRIPCIONES =====
            // Carlos en POO101 y BD102
            est1.InscribirCurso(curso1);
            curso1.AgregarEstudiante(est1);
            est1.InscribirCurso(curso2);
            curso2.AgregarEstudiante(est1);
            est1.InscribirCurso(curso3);
            curso3.AgregarEstudiante(est1);
            est1.InscribirCurso(curso4);
            curso4.AgregarEstudiante(est1);
            est1.RemoverCurso(curso1);
            curso1.RemoverEstudiante(est1);

            // Ana en WEB103 y ALG104
            est2.InscribirCurso(curso3);
            curso3.AgregarEstudiante(est2);
            est2.InscribirCurso(curso4);
            curso4.AgregarEstudiante(est2);

            // Pedro en RED105 y SO106
            est3.InscribirCurso(curso5);
            curso5.AgregarEstudiante(est3);
            est3.InscribirCurso(curso6);
            curso6.AgregarEstudiante(est3);

            // Laura en IA107 y SEC108
            est4.InscribirCurso(curso7);
            curso7.AgregarEstudiante(est4);
            est4.InscribirCurso(curso8);
            curso8.AgregarEstudiante(est4);

            // Javier en MOV109 y ARQ110
            est5.InscribirCurso(curso9);
            curso9.AgregarEstudiante(est5);
            est5.InscribirCurso(curso10);
            curso10.AgregarEstudiante(est5);

            // Otros estudiantes en distintos cursos
            est6.InscribirCurso(curso1);
            curso1.AgregarEstudiante(est6);

            est7.InscribirCurso(curso2);
            curso2.AgregarEstudiante(est7);

            est8.InscribirCurso(curso3);
            curso3.AgregarEstudiante(est8);

            est9.InscribirCurso(curso4);
            curso4.AgregarEstudiante(est9);

            est10.InscribirCurso(curso5);
            curso5.AgregarEstudiante(est10);

            // ===== MOSTRAR INFORMACIÓN =====
            est1.MostrarInformacion();
            est2.MostrarInformacion();
            curso1.MostrarInformacion();
            curso3.MostrarInformacion();
        }
    }
}
