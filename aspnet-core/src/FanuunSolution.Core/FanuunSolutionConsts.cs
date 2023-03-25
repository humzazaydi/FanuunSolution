using FanuunSolution.Debugging;

namespace FanuunSolution
{
    public class FanuunSolutionConsts
    {
        public const string LocalizationSourceName = "FanuunSolution";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "8df5fa9bbeae43bbb0dd5a7be7be2143";
    }
}
