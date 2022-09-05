namespace Cookbook.Dto;

using Cookbook.Domain;

public static class AccountDtoExtension
{
    public static Account ConvertToAccount( this AccountDto accountDto )
    {
        return new Account(
            accountDto.Id,
            accountDto.Name ?? "",
            accountDto.Login ?? "",
            accountDto.Password ?? ""
        );
    }

    public static AccountDto ConvertToAccountDto( this Account account )
    {
        return new AccountDto
        {
            Id = account.Id,
            Name = account.Name ?? "",
            Login = account.Login ?? "",
            Password = account.Password ?? ""
        };
    }
}
