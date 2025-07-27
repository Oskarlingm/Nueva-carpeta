namespace SistemaGestióndeEstudiantesCursos
{
    class Curso
    {

        private string? _codigo;
        private string? _nombre;
        private int _creditos;
        List<Estudiante> _estudiantesInscritos;

        public Curso(string codigo, string nombre, int creditos)
        {
            if (codigo == string.Empty)
                throw new ArgumentException("El codigo esta vacio o invalido.");

            if (nombre == string.Empty)
                throw new ArgumentException("El nombre esta vacio");


            if (creditos < 1 || creditos > 5)
                throw new ArgumentException("Los creditos son menores o mayores a los permitidos");


            _codigo = codigo;
            _creditos = creditos;
            _nombre = nombre;
            _estudiantesInscritos = new List<Estudiante>();
        }

        public void getNombre()
        {
            System.Console.WriteLine(_nombre);

        }

        // Métodos públicos:

        // AgregarEstudiante(Estudiante estudiante)
        // Agrega solo si no está ya inscrito.


        // RemoverEstudiante(Estudiante estudiante)

        public void AgregarEstudiante(Estudiante estudiante)
        {

            if (_estudiantesInscritos.Contains(estudiante))
                throw new ArgumentException("El estudiante ya esta agregado al curso");

            _estudiantesInscritos.Add(estudiante);

        }

        public void RemoverEstudiante(Estudiante estudiante)
        {
            if (estudiante == null)
                throw new ArgumentException("Estudiante Invalido.");


            if (_estudiantesInscritos.Contains(estudiante))
            {
                _estudiantesInscritos.Remove(estudiante);
                return;
            }
            throw new Exception("Estudiante no inscrito.");

        }

        // MostrarInformacion()
        // Muestra info + cantidad de estudiantes inscritos.
        // ---
        public void MostrarInformacion()
        {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("- MOSTRANDO INFORMACION DEL CURSO -");
            System.Console.WriteLine(" ");
            System.Console.WriteLine($@"Codigo del curso: {_codigo}
            Nombre del curso: {_nombre}
            Creditos del curso: {_creditos}");

            System.Console.Write($"La cantidad de estudiantes inscridos es de: {_estudiantesInscritos.Count()}");
            System.Console.WriteLine(" ");
            
        }

        // ---


    }
}