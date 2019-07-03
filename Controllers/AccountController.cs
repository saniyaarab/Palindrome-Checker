using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using ProjectAttempt1.Models;


namespace ProjectAttempt1.Controllers {
    public class AccountController : Controller {
        
        [Route("Account")]
        [HttpPost]
        public IActionResult Authorize([FromBody] Login login) {  //method naming convention is pascal case
            
            return Ok();
        }

        [Route("CheckIfPalindrome")]
        [HttpPost]
        public IActionResult checkForPalindrome([FromBody] Login login) {  

            //all letters should be either lower or upper case
            //spaces be removed
            //split the words in array
            //reverse them
            //trim the trailing spaces
            //compare the userstrign value with the new value

            string word = login.userString;
            word = word.ToLower().Replace(" ", "");
            Char[] d = word.ToCharArray();
            string result;

            Array.Reverse(d);
            String reversedWord = String.Join("", d);
            if (reversedWord == word) {
                result = "This is a Palindrome";
            } else {
                result = "This is not a Palindrome";
            }

            return Content(result);
            
        }
    }

}
