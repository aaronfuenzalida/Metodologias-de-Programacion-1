using Metodologias_de_Programacion.Clase_4_Adapter__Decorator;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Models;
using Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Interfaces;

namespace Metodologias_de_Programacion.Clase_4_Adapter__Decorator.Adapter
{
    public class AlumnoAdapter : Student
    {
        private IAlumno alumno;

        public AlumnoAdapter(IAlumno alumno)
        {
            this.alumno = alumno;
        }

        public string getName()
        {
            return this.alumno.getNombre();
        }

        public virtual int yourAnswerIs(int question)
        {
            return this.alumno.responderPregunta(question);
        }

        public void setScore(int score)
        {
            this.alumno.setNota(score);
        }

        public string showResult()
        {
            return this.alumno.mostrarCalificacion();
        }

        public bool equals(Student student)
        {
            return this.alumno.sosIgual(((AlumnoAdapter)student).getAlumno());
        }

        public bool lessThan(Student student)
        {  
            return this.alumno.sosMenor(((AlumnoAdapter)student).getAlumno());
        }

        public bool greaterThan(Student student)
        {
            return this.alumno.sosMayor(((AlumnoAdapter)student).getAlumno());
        }

        public IAlumno getAlumno()
        {
            return this.alumno;
        }

    }

}