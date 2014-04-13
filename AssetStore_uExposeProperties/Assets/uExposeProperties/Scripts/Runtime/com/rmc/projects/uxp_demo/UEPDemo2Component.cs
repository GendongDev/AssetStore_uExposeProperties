﻿/**
 * Copyright (C) 2005-2014 by Rivello Multimedia Consulting (RMC).                    
 * code [at] RivelloMultimediaConsulting [dot] com                                                  
 *                                                                      
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the      
 * "Software"), to deal in the Software without restriction, including  
 * without limitation the rights to use, copy, modify, merge, publish,  
 * distribute, sublicense, and#or sell copies of the Software, and to   
 * permit persons to whom the Software is furnished to do so, subject to
 * the following conditions:                                            
 *                                                                      
 * The above copyright notice and this permission notice shall be       
 * included in all copies or substantial portions of the Software.      
 *                                                                      
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,      
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF   
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR    
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.                                      
 */
// Marks the right margin of code *******************************************************************


//--------------------------------------
//  Imports
//--------------------------------------
using UnityEngine;
using com.unity3d.wiki.expose_properties;

//--------------------------------------
//  Namespace
//--------------------------------------
namespace com.rmc.projects.uxp_demo
{
	
	//--------------------------------------
	//  Namespace Properties
	//--------------------------------------
	
	//--------------------------------------
	//  Class Attributes
	//--------------------------------------
	
	
	//--------------------------------------
	//  Class
	//--------------------------------------
	public class UEPDemo2Component : MonoBehaviour 
	{
		
		//--------------------------------------
		//  Attributes
		//--------------------------------------

		//--------------------------------------
		//  Properties
		//--------------------------------------
		
		/// <summary>
		/// Sample Float
		/// </summary>
		[SerializeField][HideInInspector]
		private float _justAnotherExampleNumber_float = 15;
		[ExposeProperty]
		public float justAnotherExampleNumber {
			get{
				return _justAnotherExampleNumber_float;
			}
			set{

				_justAnotherExampleNumber_float = value;

				//SHOW THE VALUE FOR TESTING
				//Debug.Log ("justAnotherExampleNumber: " + justAnotherExampleNumber);

			}
		}


		//--------------------------------------
		//  Methods
		//--------------------------------------

		//	PUBLIC 

		/// <summary>
		/// Start this instance.
		/// </summary>
	 	void Start () 
		{
		
		}
		
		
		///<summary>
		///	Called once per frame
		///</summary>
		void Update () 
		{



		}

		//--------------------------------------
		//  Events
		//--------------------------------------

	}


}
