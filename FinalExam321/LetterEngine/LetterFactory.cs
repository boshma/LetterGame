// <copyright file="LetterFactory.cs" company="Bogdan Shmat 011738664">
// Copyright (c) Bogdan Shmat 011738664. All rights reserved.
// </copyright>

namespace LetterEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Creates letters Uppercaze A-Z.
    /// </summary>
    internal class LetterFactory
    {
        /// <summary>
        /// 26 Uppercase letters.
        /// </summary>
        public static Dictionary<char, Type> LetterDict = new Dictionary<char, Type>
        {
            { 'A', typeof(LetterA) },
            { 'B', typeof(LetterB) },
            { 'C', typeof(LetterC) },
            { 'D', typeof(LetterD) },
            { 'E', typeof(LetterE) },
            { 'F', typeof(LetterF) },
            { 'G', typeof(LetterG) },
            { 'H', typeof(LetterH) },
            { 'I', typeof(LetterI) },
            { 'J', typeof(LetterJ) },
            { 'K', typeof(LetterK) },
            { 'L', typeof(LetterL) },
            { 'M', typeof(LetterM) },
            { 'N', typeof(LetterN) },
            { 'O', typeof(LetterO) },
            { 'P', typeof(LetterP) },
            { 'Q', typeof(LetterQ) },
            { 'R', typeof(LetterR) },
            { 'S', typeof(LetterS) },
            { 'T', typeof(LetterT) },
            { 'U', typeof(LetterU) },
            { 'V', typeof(LetterV) },
            { 'W', typeof(LetterW) },
            { 'X', typeof(LetterX) },
            { 'Y', typeof(LetterY) },
            { 'Z', typeof(LetterZ) },
        };

        /// <summary>
        /// Creates instance of letter object.
        /// </summary>
        /// <param name="inputChar">Inputted letter.</param>
        /// <returns>Letter object or null.</returns>
        public static Letter CreateLetter(char inputChar)
        {
            if (LetterDict.ContainsKey(inputChar))
            {
                object letterObj = System.Activator.CreateInstance(LetterDict[inputChar]);
                if (letterObj is Letter)
                {
                    return (Letter)letterObj;
                }
            }

            return null;
        }
    }
}
