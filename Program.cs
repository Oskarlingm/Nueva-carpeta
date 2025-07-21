// 🧠 Ejercicio Avanzado: Sistema de Gestión de Estudiantes y Cursos

// 🎯 Objetivo:

// Modelar un sistema educativo donde se puedan registrar estudiantes, asignarlos a cursos y llevar un control de sus calificaciones.

// ---

// 🔧 Clases involucradas:

// 1. Estudiante

// Atributos privados:

// matricula (string)

// nombre (string)

// apellido (string)

// edad (int)

// cursosInscritos (List<Curso>)


// Validaciones:

// La matrícula no puede estar vacía.

// Edad debe ser ≥ 16

// El nombre y apellido no pueden estar vacíos.


// Métodos públicos:

// InscribirCurso(Curso curso)

// No permite inscribirse dos veces al mismo curso.


// RemoverCurso(Curso curso)

// Solo si ya está inscrito.


// MostrarInformacion()

// Muestra los datos del estudiante + nombres de los cursos.

// ---

// 2. Curso

// Atributos privados:

// codigo (string)

// nombre (string)

// creditos (int)

// estudiantesInscritos (List<Estudiante>)


// Validaciones:

// Código y nombre no pueden estar vacíos.

// Créditos deben ser entre 1 y 5.


// Métodos públicos:

// AgregarEstudiante(Estudiante estudiante)

// Agrega solo si no está ya inscrito.


// RemoverEstudiante(Estudiante estudiante)

// MostrarInformacion()

// Muestra info + cantidad de estudiantes inscritos.

// ---

// 3. Clase opcional: Calificacion

// Podrías agregarla más adelante si quieres registrar notas por curso y estudiante.

// ---

// 💡 Ejemplo de uso:

// Curso curso1 = new Curso("POO101", "Programación Orientada a Objetos", 4);
// Curso curso2 = new Curso("BD102", "Base de Datos", 3);

// Estudiante est1 = new Estudiante("2022-001", "Carlos", "Martínez", 18);

// est1.InscribirCurso(curso1);
// curso1.AgregarEstudiante(est1);

// est1.MostrarInformacion(); // Muestra sus cursos
// curso1.MostrarInformacion(); // Muestra a Carlos como inscrito