﻿using System;
using System.Collections.Generic;
using System.Linq;
using Design_Patterns.Behavioral.Observer;
using Design_Patterns.Structural.Proxy;
using Design_Patterns.Behavioral.Command;
using Design_Patterns.Structural.Decorator;
using Design_Patterns.Behavioral.Strategy;
using Design_Patterns.Behavioral.TemplateMethod;
using Design_Patterns.Behavioral.ChainOfResponsibility;
using Design_Patterns.Behavioral.Mediator;
using Design_Patterns.Behavioral.Visitor;
using Design_Patterns.Creational.Prototype;

namespace Design_Patterns
{
    class Program
    {
        static public void Println<T>(T value)
        {
            Console.WriteLine(value);
        }
        static void Main(string[] args)
        {
            // Run observer example
            //_ = new Observer();

            // Run Proxy example

            /*_ = new Proxy();*/

            //_ = new CommandPatternApp();

            //_ = new DecoratorPatternApp();

            //_ = new StrategyPatternApp();

            //_ = new TemplateMethodPatternApp();

            //_ = new ChainOfResponsibilityApp();

            //_ = new MediatorPatternApp();

            //_ = new VisitorPatternApp();

            _ = new PrototypePatternApp();

        }
    }

}
