using BusinessEntities.Context;
using BusinessEntities.GeneratedModels;
using BusinessEntities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Identity
{
    public class CustomUserStore<TUserLogin> : IUserStore<User>,
        IUserPasswordStore<User>, IUserEmailStore<User>
        , IUserLoginStore<User>
        //where TKey : IEquatable<TKey>
        where TUserLogin : IdentityUserLogin<string>, new()
        //where TUser : IdentityUser, new()
    {
        private readonly MovieContext _context;

        public CustomUserStore(MovieContext dbContext)
        {
            _context = dbContext;
        }

        #region IUserStore implementation

        public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentException(nameof(User));

            _context.User.Add(user);
            return await _context.SaveChangesAsync() == 0 ? IdentityResult.Failed(new IdentityError() { Description = $"Could not insert user {user.Email}." }) : IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            _context.User.Remove(user);
            return await _context.SaveChangesAsync() == 0 ? IdentityResult.Failed(new IdentityError() { Description = $"Could not delete user {user.Email}." }) : IdentityResult.Success;
        }

        public async Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (string.IsNullOrEmpty(userId)) throw new ArgumentNullException(nameof(userId));

            Guid idGuid;
            if (!Guid.TryParse(userId, out idGuid))
            {
                throw new ArgumentException("Not a valid Guid id", nameof(userId));
            }

            return await _context.User.FindAsync(idGuid.ToString());
        }

        public async Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(normalizedUserName)) throw new ArgumentNullException(nameof(normalizedUserName));

            return await _context.User.SingleOrDefaultAsync(x => x.NormalizedUserName == normalizedUserName, cancellationToken);
        }

        public Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.NormalizedUserName);
        }

        public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.Id.ToString());
        }

        public Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.UserName);

        }

        public Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(normalizedName)) throw new ArgumentNullException(nameof(normalizedName));

            user.NormalizedUserName = normalizedName;
            return Task.FromResult<object>(null);
        }

        public Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(userName)) throw new ArgumentNullException(nameof(userName));

            user.UserName = userName;
            return Task.FromResult<object>(null);
        }

        public async Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            _context.Attach(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync() == 0 ? IdentityResult.Failed(new IdentityError() { Description = $"Could not insert user {user.Email}." }) : IdentityResult.Success;
        }

        public void Dispose()
        {

        }

        #endregion

        #region IUserEmailStore implementation

        public async Task<User> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (string.IsNullOrEmpty(normalizedEmail)) throw new ArgumentNullException(nameof(normalizedEmail));

            return await _context.User.SingleOrDefaultAsync(x => x.NormalizedEmail == normalizedEmail);
        }

        public Task<string> GetEmailAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.Email);
        }

        public Task<bool> GetEmailConfirmedAsync(User user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.EmailConfirmed);
        }

        public Task<string> GetNormalizedEmailAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.NormalizedEmail);
        }

        public Task SetEmailAsync(User user, string email, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(email)) throw new ArgumentNullException(nameof(email));

            user.Email = email;
            return Task.FromResult<object>(null);
        }

        public Task SetEmailConfirmedAsync(User user, bool confirmed, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            user.EmailConfirmed = confirmed;
            return Task.FromResult<object>(null);
        }

        public Task SetNormalizedEmailAsync(User user, string normalizedEmail, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(normalizedEmail)) throw new ArgumentNullException(nameof(normalizedEmail));

            user.NormalizedEmail = normalizedEmail;
            return Task.FromResult<object>(null);
        }

        #endregion

        #region IUserPasswordStore implementation

        public Task<string> GetPasswordHashAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(User user, CancellationToken cancellationToken)
        {
            return Task.FromResult(!string.IsNullOrEmpty(user.PasswordHash));
        }

        public Task SetPasswordHashAsync(User user, string passwordHash, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(passwordHash)) throw new ArgumentNullException(nameof(passwordHash));

            user.PasswordHash = passwordHash;
            return Task.FromResult<object>(null);
        }

        #endregion

        #region IUserLoginStore implementation

        public async Task AddLoginAsync(User user, UserLoginInfo login, CancellationToken cancellationToken)
        {
            //FindUserLoginAsync
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (login == null) throw new ArgumentNullException(nameof(login));

            await _context.UserLogin.AddAsync(CreateUserLogin(user, login));
            await _context.SaveChangesAsync();
        }

        protected virtual TUserLogin CreateUserLogin(User user, UserLoginInfo login)
        {
            return new TUserLogin
            {
                UserId = user.Id,
                ProviderKey = login.ProviderKey,
                LoginProvider = login.LoginProvider,
                ProviderDisplayName = login.ProviderDisplayName
            };
        }

        public async Task RemoveLoginAsync(User user, string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            TUserLogin userLogin = await FindUserLoginAsync(loginProvider, providerKey, user);
            if (userLogin != null)
            {
                _context.UserLogin.Remove(userLogin);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IList<UserLoginInfo>> GetLoginsAsync(User user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            return await _context.UserLogin.Where(x => x.UserId.Equals(user.Id)).Select(x => new UserLoginInfo(x.LoginProvider, x.ProviderKey, x.ProviderDisplayName)).ToListAsync(cancellationToken);
        }

        public async Task<User> FindByLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            TUserLogin userLogin = await FindUserLoginAsync(loginProvider, providerKey);
            if (userLogin != null)
            {
                return await FindByIdAsync(userLogin.UserId, cancellationToken);
            }
            return null;
        }

        protected virtual async Task<TUserLogin> FindUserLoginAsync(string loginProvider, string providerKey, User user = default(User))
        {
            TUserLogin userLogin = await _context.UserLogin.Where(x => x.LoginProvider == loginProvider && x.ProviderKey == providerKey && (user != null ? x.UserId == user.Id : true))
                .Select(x => new TUserLogin()
                {
                    LoginProvider = x.LoginProvider,
                    ProviderDisplayName = x.ProviderDisplayName,
                    ProviderKey = x.ProviderKey,
                    UserId = x.UserId
                }).FirstOrDefaultAsync();

            return userLogin;
        }

        #endregion

    }
}
