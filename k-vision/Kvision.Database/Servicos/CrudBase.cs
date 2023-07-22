using Kvision.Database.Interfaces;
using NHibernate;

namespace Kvision.Database.Servicos
{
    public class CrudBase<T> : IBase<T> where T : class
    {
        private readonly IConexao _conexao;

        public CrudBase(IConexao conexao)
        {
            _conexao = conexao;
        }

        virtual public bool Delete(T entity)
        {
            bool response = false;
            using (ISession _sessao = _conexao.Abrir())
            {
                //open transaction
                using (ITransaction _transacao = _sessao.BeginTransaction())
                {
                    try
                    {
                        //save session
                        _sessao.Delete(entity);
                        //commit database
                        _transacao.Commit();
                        if (_transacao.WasCommitted)
                        {
                            response = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (!_transacao.WasCommitted)
                        {
                            _transacao.Rollback();
                        }
                    }
                    return response;
                }

            }
        }

        virtual public IList<T> FindAll()
        {
            using (ISession _sessao = _conexao.Abrir())
            {
                return (from res in _sessao.Query<T>() select res).ToList();
            }
        }

        virtual public T FindOne(int id)
        {
            //not use transaction
            //open session
            using (ISession _sessao = _conexao.Abrir())
            {
                return _sessao.Get<T>(id);
            }
        }

        virtual public bool Insert(T entity)
        {
            using (ISession _sessao = _conexao.Abrir())
            {
                bool response = false;

                using (ITransaction _transacao = _sessao.BeginTransaction())
                {
                    try
                    {
                        _sessao.Save(entity);
                        _transacao.Commit();

                        if (_transacao.WasCommitted)
                        {
                            response = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (!_transacao.WasCommitted)
                        {
                            _transacao.Rollback();
                            response = false;
                        }
                    }

                    return response;
                }

            }
        }

        virtual public bool Update(T entity)
        {
            bool response = false;

            using (ISession _sessao = _conexao.Abrir())
            {
                //open transaction
                using (ITransaction _transacao = _sessao.BeginTransaction())
                {
                    try
                    {
                        //save session
                        _sessao.Update(entity);
                        //commit database
                        _transacao.Commit();

                        if (_transacao.WasCommitted)
                        {
                            response = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (!_transacao.WasCommitted)
                        {
                            _transacao.Rollback();
                            response = false;
                        }
                    }

                    return response;
                }

            }
        }
    }
}
