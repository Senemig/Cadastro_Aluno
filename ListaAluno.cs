using System.Collections.Generic;
using System;

namespace Cadastro_Aluno
{
    public class ListaAluno
    {
        private List<Aluno> listaAlunos = new List<Aluno>();

        public void ListarAlunos()
        {
            if (listaAlunos.Count > 0)
            {
                for (int i = 0; i < listaAlunos.Count; i++)
                {
                    Console.WriteLine("Nome: " + listaAlunos[i].nome);
                    Console.WriteLine("Código: " + listaAlunos[i].codigo);
                    Console.WriteLine("Curso: " + listaAlunos[i].curso + "\n");
                }
            }

            else
            {
                Console.WriteLine("Nenhum aluno cadastrado.\n");
            }
        }

        public void IncluirAluno(Aluno aluno)
        {
            listaAlunos.Add(aluno);
        }
    }
}