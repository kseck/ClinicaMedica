﻿using ClinicaMedica.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace ClinicaMedica.Controller
{
    class PacienteController
    {
        private DataModelContainer db = new DataModelContainer();

        public List<string> Insert(Paciente paciente)
        {
            var erros = Validacao.Validar(paciente);

            try
            {
                if (erros.Count() == 0)
                {
                    db.TB_Usuario.Add(paciente);
                    db.SaveChanges();
                    return null;
                }
                else
                {
                    List<string> listaErros = new List<string>();

                    foreach (var erro in erros)
                    {
                        listaErros.Add(erro.ErrorMessage);
                    }

                    return listaErros;
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var evError in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entidade do tipo \"{0}\" no estado \"{1}\" possui os seguintes erros de validação: ",
                                       evError.Entry.Entity.GetType().Name,
                                       evError.Entry.State);

                    foreach (var valError in evError.ValidationErrors)
                    {
                        Console.WriteLine("- Propriedade: \"{0}\", Valor: \"{1}\", Erro: \"{2}\"",
                                          valError.PropertyName,
                                          evError.Entry.CurrentValues.GetValue<object>(valError.PropertyName),
                                          valError.ErrorMessage);
                    }
                }

                throw new Exception("Erro Interno. Por favor, contate o(s) administrador(es) do sistema.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível cadastrar o paciente!\n" + ex.Message);
            }
        }

        public List<ConsultaPaciente> Select()
        {
            var query = from usuario in db.TB_Usuario
                        join paciente in db.TB_Usuario_Paciente
                        on usuario.Identificacao equals paciente.Identificacao
                        orderby usuario.Identificacao ascending
                        select new ConsultaPaciente
                        {
                            Codigo = usuario.Identificacao,
                            Nome = usuario.Nome,
                            CPF = usuario.CPF,
                            RG = usuario.RG,
                            DataNascimento = usuario.DataNascimento,
                            Sexo = usuario.Sexo,
                            TelefoneResidencial = usuario.TelefoneResidencial,
                            TelefoneComercial = usuario.TelefoneComercial,
                            TelefoneCelular = usuario.TelefoneCelular,
                            Email = usuario.Email,
                            CEP = usuario.Localidade.CEP,
                            Endereco = usuario.Localidade.Endereco,
                            Numero = usuario.Localidade.Numero,
                            Complemeneto = usuario.Localidade.Complemento,
                            Bairro = usuario.Localidade.Bairro,
                            Cidade = usuario.Localidade.Cidade,
                            Estado = usuario.Localidade.Estado
                        };

            var resultado = query.ToList();
            return resultado;           
        }
    }
}