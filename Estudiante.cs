
namespace SistemaGestióndeEstudiantesCursos
{
    class Estudiante
    {

        private string? _matricula;
        private string? _nombre;
        private string? _apellido;
        private int _edad;
        private List<Curso> _cursosInscritos;

        public Estudiante(string matricula, string nombre, string apellido, int edad)
        {

            if (matricula == string.Empty)
                throw new ArgumentException("Matricula vacio o Invalido");

            if (edad < 16)
                throw new ArgumentException("Edad no permitida");

            if (nombre == string.Empty)
                throw new ArgumentException("Nombre vacio o Invalido");

            if (apellido == string.Empty)
                throw new ArgumentException("Apellido vacio o Invalido");

            _matricula = matricula;
            _nombre = nombre;
            _apellido = apellido;
            _edad = edad;
            _cursosInscritos = new List<Curso>();
        }

        // Métodos públicos:

        // InscribirCurso(Curso curso)
        // No permite inscribirse dos veces al mismo curso.

        // RemoverCurso(Curso curso)
        // Solo si ya está inscrito.

        // MostrarInformacion()
        // Muestra los datos del estudiante + nombres de los cursos.

        public void InscribirCurso(Curso curso)
        {
            if (curso == null)
                throw new ArgumentException("Curso Invalido.");

            if (_cursosInscritos.Contains(curso))
                throw new Exception("Curso ya Inscrito.");

            _cursosInscritos.Add(curso);
        }

        public void RemoverCurso(Curso curso)
        {
            if (curso == null)
                throw new ArgumentException("Curso Invalido.");


            if (_cursosInscritos.Contains(curso))
            {
                _cursosInscritos.Remove(curso);
                return;
            }
            throw new Exception("Curso no inscrito.");
        }

        public void MostrarInformacion()
        {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("- MOSTRANDO INFORMACION DE ESTUDIANTE -");
            System.Console.WriteLine(" ");
            System.Console.WriteLine($@"Matricula: {_matricula}
            Nombre: {_nombre}
            Apellido: {_apellido}
            Edad: {_edad}");

            System.Console.WriteLine("LISTA DE CURSOS:");
            foreach (var curso in _cursosInscritos)
            {
                curso.getNombre();
            }


        }


    }

    // Edad debe ser ≥ 16
    // El nombre y apellido no pueden estar vacíos.






}


