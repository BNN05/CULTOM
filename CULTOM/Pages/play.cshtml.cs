using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CULTOM.Pages
{
    public class Index1Model : PageModel
    {
        private String word = "testtest";
        public void OnGet()
        {
            
        }
        public String getWord() { 
            return word;
        }
        
        public String TestWord(String word, String propose)
        {

            char[] lettersWord = word.ToCharArray();
            char[] lettersPropose = propose.ToCharArray();
            int[] lettersTest = new int[lettersWord.Length];
            // 0 = None | 1 = In the word | 2 = In good place
            
            for(int i = 0; i < lettersTest.Length; i++)
            {
                lettersTest[i] = 0;
            }
            if (lettersWord.Length != lettersPropose.Length)
            {
                return "bad size";
            }
            for (int i = 0; i < lettersWord.Length; i++)
            {
                if( lettersWord[i] == lettersPropose[i])
                {
                    lettersTest[i] = 2;
                    
                }
                else
                {
                    for(int j = 0; j < lettersWord.Length; j++)
                    {
                        if (lettersPropose[i] == lettersWord[j])
                        {
                            lettersTest[i] = 1;
                        }
                    }
                }
            }
            String test = " ";
            for(int i = 0;i < lettersTest.Length;i++)
            {
                test = test + lettersTest[i];
            }
            return test;
                
        }
    }
}
