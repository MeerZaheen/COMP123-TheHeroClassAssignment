﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* COMP123-The Hero Class Assignment
* Author: Meer Zaheen Nazmul
* Student ID: 300522487
* Date Last Modified: June 2nd 2016
* Program Description: Using MS Visual Studio, Build and Implement a Hero Class
* GitHub Link: https://github.com/MeerZaheen/COMP123-TheHeroClassAssignment.git
*
* Revision History:
* a) Initial commit to add default .gitIgnore and .gitAttribute files.
*       Date: May 31st, 2016, 8:27pm
* b) Initial Commit
*       Date: May 31st, 2016
* c) Part a complete
*       Date: May 31st 2016, 8:40pm
* d) Part 1b, c, d done
*       Date: May 31st 2016, 9:30pm
* e) working on 1e
*       Date: May 31st, 2016, 9:30pm
* 
*/
namespace COMP123_TheHeroClassAssignment
{
    /**
    * This class defines a Hero
    *
    * @class Hero
    * @field _name {string}
    * @field _strength {int}
    * @field _speed {int}
    * @field _health {int}
    */
    class Hero
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _strength;
        private int _speed;
        private int _health;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This is a property for our _name field
        * </summary>
        *
        * @property {string} Name
        */

        private string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this._name = value;
            }
        }

        /**
        * <summary>
        * This is a property for our _strength field
        * </summary>
        *
        * @property {int} Strength
        */

        private int Strength
        {
            get
            {
                return _strength;
            }
            set
            {
                this._strength = value;
            }
        }

        /**
        * <summary>
        * This is a property for our _speed field
        * </summary>
        *
        * @property {int} Speed
        */

        private int Speed
        {
            get
            {
                return _speed;
            }
            set
            {
                this._speed = value;
            }
        }

        /**
        * <summary>
        * This is a property for our _health field
        * </summary>
        *
        * @property {int} Health
        */

        private int Health
        {
            get
            {
                return _health;
            }
            set
            {
                this._health = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
        * <summary>
        * This is the default empty constructor method for the Hero class
        * </summary>
        * 
        * @constructor Hero
        */

        public Hero()
        {
            this.Name = "Unknown Name";
        }

        /**
        * <summary>
        * This is a constructor that takes name as a parameter and passes it to the _name private instance variable.
        * This constructor also calls the _generateAbilities method 
        * </summary>
        *
        * @constructor Hero
        * @param {string} name
        */
        public Hero(string name)
        {
            this._name = name;
            generateAbilities();
        }

        /**
        * <summary>
        * This is a private _generateAbilities method that randomly generates the ability numbers for the following fields
        * from the private instance variables
        * </summary>
        *
        * @method _generateAbilities
        * @param {int} Strength
        * @param {int} Health
        * @param {int} Speed
        */
        private void generateAbilities()
        {
            Random numbers = new Random();
            this._strength = numbers.Next(1, 101); // random number between 1 and 100
            this._health = numbers.Next(1, 101);   // random number between 1 and 100
            this._speed = numbers.Next(1, 101);    // random number between 1 and 100
        }

        /**
        * <summary>
        * This method randomly determines if the Hero hits (20% of the time)
        * </summary>
        *
        * @method _hitAttempt
        * @returns {bool}
        */

        private bool _hitAttempt()
        {
            Random integer = new Random();
            if (integer.Next(1, 6) == 2) // random number between 1 and 5
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
        * <summary>
        * This method calculates the damage the Hero causes to the target on a 20% hit by a number between 1 and 6
        * </summary>
        *
        * @method _hitDamage
        * @returns {int} damage
        */
        private int _hitDamage()
        {
            Random value = new Random();
            int damage = value.Next(1, 7) * _strength; // creates a random number between 1 and 6
            return damage;
        }

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        
        
        /**
        * <summary>
        * This method calls the private _hitAttempt value based on _hitDamage IF the hero was able to successfully
        * hit the target based on 20%
        * </summary>
        *
        * @method Fight
        * @returns {void}
        */
        public void Fight()
        {
            Console.WriteLine("||||Attempting to attack.....||||");
            Console.WriteLine();
                if (_hitAttempt() == true)
                {
                    Console.WriteLine("successful hit!! {0} damage was dealth", _hitDamage());
                }
                else
                {
                    Console.WriteLine("Sorry, you missed. Try again");
                }
        }

        /**
         * <summary>
         * This method printsHeros attributes on console
         * </summary>
         * 
         * @method Show
         * @returns {void}
         */
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("||||||- Hero's Attributes- ||||||");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("||Properties||          ||Value||");
            Console.WriteLine("--------------          ---------");
            Console.WriteLine("||Strength        |       ||{0}||", _strength);
            Console.WriteLine("||Speed           |       ||{0}||", _speed);
            Console.WriteLine("||Health          |       ||{0}||", _health);
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
        }

    }
}
