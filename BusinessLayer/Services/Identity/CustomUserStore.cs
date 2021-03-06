﻿using BusinessEntities.Context;
using BusinessEntities.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLayer.Services.Identity
{

    public class CustomUserStore : CustomBaseUserStore<User, string, UserLogin, UserRole, Role, UserClaim, MovieContext>
    {
        public CustomUserStore(MovieContext dbContext) : base(dbContext) { }
    }

    public class CustomBaseUserStore<TUser, TKey, TUserLogin, TUserRole, TRole, TUserClaim, TContext> : IUserStore<TUser>,
        IUserPasswordStore<TUser>,
        IUserEmailStore<TUser>,
        IUserLoginStore<TUser>,
        IUserSecurityStampStore<TUser>,
        IUserPhoneNumberStore<TUser>,
        IUserLockoutStore<TUser>,
        IUserRoleStore<TUser>,
        IUserClaimStore<TUser>,
        IQueryableUserStore<TUser>
        where TUser : IdentityUser<TKey>
        where TKey : IEquatable<TKey>
        where TUserLogin : IdentityUserLogin<TKey>, new()
        where TUserRole : IdentityUserRole<TKey>, new()
        where TRole : IdentityRole<TKey>
        where TUserClaim : IdentityUserClaim<TKey>, new()
        where TContext : IdentityDbContext<TUser, TKey, TUserLogin, TRole, TUserRole, TUserClaim>
    {
        private readonly TContext _context;

        public IQueryable<TUser> Users => _context.User;

        public CustomBaseUserStore(TContext dbContext)
        {
            _context = dbContext;
        }

        public CustomBaseUserStore() { }

        #region IUserStore implementation

        public async Task<IdentityResult> CreateAsync(TUser user, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentException(nameof(user));

            _context.User.Add(user);
            return await _context.SaveChangesAsync() == 0 ? IdentityResult.Failed(new IdentityError() { Description = $"Could not insert user {user.Email}." }) : IdentityResult.Success;
        }

        public async Task<IdentityResult> DeleteAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            _context.User.Remove(user);
            return await _context.SaveChangesAsync() == 0 ? IdentityResult.Failed(new IdentityError() { Description = $"Could not delete user {user.Email}." }) : IdentityResult.Success;
        }

        public async Task<TUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
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

        public async Task<TUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(normalizedUserName)) throw new ArgumentNullException(nameof(normalizedUserName));

            return await _context.User.SingleOrDefaultAsync(x => x.NormalizedUserName == normalizedUserName, cancellationToken);
        }

        public Task<string> GetNormalizedUserNameAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.NormalizedUserName);
        }

        public Task<string> GetUserIdAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.Id.ToString());
        }

        public Task<string> GetUserNameAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.UserName);

        }

        public Task SetNormalizedUserNameAsync(TUser user, string normalizedName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(normalizedName)) throw new ArgumentNullException(nameof(normalizedName));

            user.NormalizedUserName = normalizedName;
            return Task.FromResult<object>(null);
        }

        public Task SetUserNameAsync(TUser user, string userName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(userName)) throw new ArgumentNullException(nameof(userName));

            user.UserName = userName;
            return Task.FromResult<object>(null);
        }

        public async Task<IdentityResult> UpdateAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            _context.Attach(user).State = EntityState.Modified;

            return await _context.SaveChangesAsync() == 0 ? IdentityResult.Failed(new IdentityError() { Description = $"Could not update user {user.Email}." }) : IdentityResult.Success;
        }

        public void Dispose()
        {

        }

        #endregion

        #region IUserEmailStore implementation

        public async Task<TUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (string.IsNullOrEmpty(normalizedEmail)) throw new ArgumentNullException(nameof(normalizedEmail));

            return await _context.User.SingleOrDefaultAsync(x => x.NormalizedEmail == normalizedEmail);
        }

        public Task<string> GetEmailAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.Email);
        }

        public Task<bool> GetEmailConfirmedAsync(TUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.EmailConfirmed);
        }

        public Task<string> GetNormalizedEmailAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.NormalizedEmail);
        }

        public Task SetEmailAsync(TUser user, string email, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(email)) throw new ArgumentNullException(nameof(email));

            user.Email = email;
            return Task.FromResult<object>(null);
        }

        public Task SetEmailConfirmedAsync(TUser user, bool confirmed, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            user.EmailConfirmed = confirmed;
            return Task.FromResult<object>(null);
        }

        public Task SetNormalizedEmailAsync(TUser user, string normalizedEmail, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(normalizedEmail)) throw new ArgumentNullException(nameof(normalizedEmail));

            user.NormalizedEmail = normalizedEmail;
            return Task.FromResult<object>(null);
        }

        #endregion

        #region IUserPasswordStore implementation

        public Task<string> GetPasswordHashAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.PasswordHash);
        }

        public Task<bool> HasPasswordAsync(TUser user, CancellationToken cancellationToken)
        {
            return Task.FromResult(!string.IsNullOrEmpty(user.PasswordHash));
        }

        public Task SetPasswordHashAsync(TUser user, string passwordHash, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(passwordHash)) throw new ArgumentNullException(nameof(passwordHash));

            user.PasswordHash = passwordHash;
            return Task.FromResult<object>(null);
        }

        #endregion

        #region IUserLoginStore implementation

        public async Task AddLoginAsync(TUser user, UserLoginInfo login, CancellationToken cancellationToken)
        {
            //FindUserLoginAsync
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (login == null) throw new ArgumentNullException(nameof(login));

            await _context.UserLogin.AddAsync(CreateUserLogin(user, login));
            await _context.SaveChangesAsync();
        }

        protected virtual TUserLogin CreateUserLogin(TUser user, UserLoginInfo login)
        {
            return new TUserLogin
            {
                UserId = user.Id,
                ProviderKey = login.ProviderKey,
                LoginProvider = login.LoginProvider,
                ProviderDisplayName = login.ProviderDisplayName
            };
        }

        public async Task RemoveLoginAsync(TUser user, string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            TUserLogin userLogin = await FindUserLoginAsync(loginProvider, providerKey, user);
            if (userLogin != null)
            {
                _context.UserLogin.Remove(userLogin);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }

        public async Task<IList<UserLoginInfo>> GetLoginsAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            return await _context.UserLogin.Where(x => x.UserId.Equals(user.Id)).Select(x => new UserLoginInfo(x.LoginProvider, x.ProviderKey, x.ProviderDisplayName)).ToListAsync(cancellationToken);
        }

        public async Task<TUser> FindByLoginAsync(string loginProvider, string providerKey, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            TUserLogin userLogin = await FindUserLoginAsync(loginProvider, providerKey);

            if (userLogin != null)
            {
                return await FindByIdAsync(userLogin.UserId.ToString(), cancellationToken);
            }
            return null;
        }

        protected virtual async Task<TUserLogin> FindUserLoginAsync(string loginProvider, string providerKey, TUser user)
        {
            TUserLogin userLogin = await _context.UserLogin.Where(x => x.LoginProvider == loginProvider && x.ProviderKey == providerKey && x.UserId.Equals(user.Id))
                .Select(x => new TUserLogin()
                {
                    LoginProvider = x.LoginProvider,
                    ProviderDisplayName = x.ProviderDisplayName,
                    ProviderKey = x.ProviderKey,
                    UserId = x.UserId
                }).FirstOrDefaultAsync();

            return userLogin;
        }

        protected virtual async Task<TUserLogin> FindUserLoginAsync(string loginProvider, string providerKey)
        {
            TUserLogin userLogin = await _context.UserLogin.Where(x => x.LoginProvider == loginProvider && x.ProviderKey == providerKey)
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

        #region IUserSecurityStampStore

        public Task SetSecurityStampAsync(TUser user, string stamp, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(stamp)) throw new ArgumentNullException(nameof(stamp));

            user.SecurityStamp = stamp;
            return Task.CompletedTask;
        }

        public Task<string> GetSecurityStampAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.SecurityStamp);
        }

        #endregion

        #region IUserPhoneNumberStore

        public Task SetPhoneNumberAsync(TUser user, string phoneNumber, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (string.IsNullOrEmpty(phoneNumber)) throw new ArgumentNullException(nameof(phoneNumber));

            user.PhoneNumber = phoneNumber;
            return Task.CompletedTask;
        }

        public Task<string> GetPhoneNumberAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.PhoneNumber);
        }

        public Task<bool> GetPhoneNumberConfirmedAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.PhoneNumberConfirmed);
        }

        public Task SetPhoneNumberConfirmedAsync(TUser user, bool confirmed, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            user.PhoneNumberConfirmed = confirmed;
            return Task.CompletedTask;
        }

        #endregion

        #region IUserLockoutStore

        public Task<DateTimeOffset?> GetLockoutEndDateAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.LockoutEnd);
        }

        public Task SetLockoutEndDateAsync(TUser user, DateTimeOffset? lockoutEnd, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            user.LockoutEnd = lockoutEnd;
            return Task.CompletedTask;
        }

        public Task<int> IncrementAccessFailedCountAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            user.AccessFailedCount++;
            return Task.FromResult(user.AccessFailedCount);
        }

        public Task ResetAccessFailedCountAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            user.AccessFailedCount = 0;
            return Task.CompletedTask;
        }

        public Task<int> GetAccessFailedCountAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.AccessFailedCount);
        }

        public Task<bool> GetLockoutEnabledAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return Task.FromResult(user.LockoutEnabled);
        }

        public Task SetLockoutEnabledAsync(TUser user, bool enabled, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            user.LockoutEnabled = enabled;
            return Task.CompletedTask;
        }

        #endregion

        #region IUserRoleStore

        public async Task AddToRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentException(nameof(user));
            if (string.IsNullOrEmpty(roleName)) throw new ArgumentException(nameof(roleName));

            TRole role = await FindRoleAync(roleName, cancellationToken);

            await _context.UserRole.AddAsync(CreateUserRole(user, role));
            await _context.SaveChangesAsync();
        }

        private TUserRole CreateUserRole(TUser user, TRole role)
        {
            return new TUserRole()
            {
                UserId = user.Id,
                RoleId = role.Id
            };
        }

        protected virtual async Task<TRole> FindRoleAync(string normalizedName, CancellationToken cancellationToken)
        {
            return await _context.Role.SingleOrDefaultAsync(x => x.NormalizedName == normalizedName, cancellationToken);
        }

        public async Task RemoveFromRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentException(nameof(user));
            if (string.IsNullOrEmpty(roleName)) throw new ArgumentException(nameof(roleName));

            TRole role = await FindRoleAync(roleName, cancellationToken);

            if (role != null)
            {
                var userRole = await FindUserRoleAsync(user.Id, role.Id, cancellationToken);

                if (userRole != null)
                {
                    _context.Remove(userRole);
                    await _context.SaveChangesAsync();
                }
            }
        }

        public async Task<TUserRole> FindUserRoleAsync(TKey userId, TKey roleId, CancellationToken cancellationToken)
        {
            return await _context.UserRole.FindAsync(new object[] { userId, roleId }, cancellationToken);
        }

        public async Task<IList<string>> GetRolesAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentException(nameof(user));

            var roles = from userRole in _context.UserRole
                        join role in _context.Role on userRole.RoleId equals role.Id
                        where userRole.UserId.Equals(user.Id)
                        select role.Name;

            return await roles.ToListAsync(cancellationToken);
        }

        public async Task<bool> IsInRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentException(nameof(user));

            var role = await FindRoleAync(roleName, cancellationToken);

            if (role != null)
            {
                var userRole = await FindUserRoleAsync(user.Id, role.Id, cancellationToken);

                if (userRole != null)
                {
                    return true;
                }
            }
            return false;
        }

        public async Task<IList<TUser>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (string.IsNullOrEmpty(roleName)) throw new ArgumentException(nameof(roleName));

            var role = await FindRoleAync(roleName, cancellationToken);

            var users = from user in _context.User
                        join userRole in _context.UserRole on user.Id equals userRole.UserId
                        join roles in _context.Role on userRole.RoleId equals roles.Id
                        where roles.NormalizedName == roleName
                        select user;

            return await users.ToListAsync(cancellationToken);
        }

        #endregion

        #region IUserClaimStore

        public async Task<IList<Claim>> GetClaimsAsync(TUser user, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));

            return await (_context.UserClaim.Where(x => x.UserId.Equals(user)).Select(x => x.ToClaim())).ToListAsync(cancellationToken);
        }

        public async Task AddClaimsAsync(TUser user, IEnumerable<Claim> claims, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (claims == null || claims.Count() == 0) throw new ArgumentNullException(nameof(claims));

            List<TUserClaim> claimsForAdd = new List<TUserClaim>();

            foreach (var claim in claims)
            {
                claimsForAdd.Add(CreateUserClaim(user, claim));
            }

            await _context.UserClaim.AddRangeAsync(claimsForAdd, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public virtual TUserClaim CreateUserClaim(TUser user, Claim claim)
        {
            return new TUserClaim()
            {
                UserId = user.Id,
                ClaimType = claim.Type,
                ClaimValue = claim.Value
            };
        }

        public async Task ReplaceClaimAsync(TUser user, Claim claim, Claim newClaim, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (claim == null) throw new ArgumentNullException(nameof(claim));
            if (newClaim == null) throw new ArgumentNullException(nameof(newClaim));

            var matchedClaims = await _context.UserClaim.Where(x => x.UserId.Equals(user.Id) && x.ClaimType.Equals(claim.ValueType) && x.ClaimValue.Equals(claim.Value)).ToListAsync(cancellationToken);

            foreach (var matchedClaim in matchedClaims)
            {
                _context.Attach(matchedClaim).State = EntityState.Modified;
                matchedClaim.InitializeFromClaim(newClaim);
            }
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task RemoveClaimsAsync(TUser user, IEnumerable<Claim> claims, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (user == null) throw new ArgumentNullException(nameof(user));
            if (claims == null || claims.Count() == 0) throw new ArgumentNullException(nameof(claims));

            List<TUserClaim> claimsForDeleted = new List<TUserClaim>();

            foreach (var claim in claims)
            {
                claimsForDeleted.Add(CreateUserClaim(user, claim));
            }

            _context.UserClaim.RemoveRange(claimsForDeleted);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<IList<TUser>> GetUsersForClaimAsync(Claim claim, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            if (claim == null) throw new ArgumentNullException(nameof(claim));

            var users = from userClaim in _context.UserClaim
                        join user in _context.User on userClaim.UserId equals user.Id
                        where userClaim.ClaimType == claim.Type && userClaim.ClaimValue == claim.Value
                        select user;

            return await users.ToListAsync(cancellationToken);
        }

        #endregion
    }
}
