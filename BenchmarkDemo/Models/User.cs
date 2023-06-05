namespace BenchmarkDemo.Models
{
    public class User
    {
        public User()
        {
            CreatedDate = DateTime.UtcNow;
        }

        /// <summary>
        /// Gets or sets the unique identifier of the model.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the model in UTC time.
        /// </summary>
        public DateTime CreatedDate { get; set; }
        public required string UserName { get; set; }


        public required string Role { get; set; }

        /// <summary>
        /// The email of the user.
        /// </summary>
        public required string Email { get; set; }

        /// <summary>
        /// The password hash of the user.
        /// </summary>
        public Guid PasswordHash { get; set; }

        /// <summary>
        /// The password salt of the user.
        /// </summary>
        public Guid PasswordSalt { get; set; }

        /// <summary>
        /// The refresh token of the user.
        /// </summary>
        public string? RefreshToken { get; set; }

        /// <summary>
        /// A flag indicating whether the user has been falsely deleted.
        /// </summary>
        public bool IsFalseDeleted { get; set; }

        /// <summary>
        /// The date when the user was falsely deleted.
        /// </summary>
        public DateTime FalseDeletedDate { get; set; }

        /// <summary>
        /// The time when the user is allowed to set a new password.
        /// </summary>
        public DateTime AllowSetNewPassword { get; set; }


        public DateTime RefreshTokenExpireTime { get; set; }

        /// <summary>
        /// The password recovery pin of the user.
        /// </summary>
        public int PasswordRecoveryPin { get; set; }

        /// <summary>
        /// The time when the password recovery pin was created.
        /// </summary>
        public DateTime RecoveryPinCreationTime { get; set; }
    }
}
