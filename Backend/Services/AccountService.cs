namespace Cookbook.Services;

using Cookbook.Domain;
using Cookbook.Dto;
using Cookbook.Repositories;
using Cookbook.UnitOfWork;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AccountService( IAccountRepository accountRepository, IUnitOfWork unitOfWork )
    {
        _accountRepository = accountRepository;
        _unitOfWork = unitOfWork;
    }

    // TODO: Remove from Read UoW

    public Account GetById( int id )
    {
        var account = _accountRepository.GetById( id );
        _unitOfWork.Commit();
        return account;
    }

    public Account GetByLogin( string login )
    {
        var account = _accountRepository.GetByLogin( login );
        _unitOfWork.Commit();
        return account;
    }

    public void Add( Account account )
    {
        _accountRepository.Add( account );
        _unitOfWork.Commit();
    }
}
