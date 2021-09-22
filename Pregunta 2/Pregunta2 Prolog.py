# -*- coding: utf-8 -*-
"""
Created on Thu Aug 26 10:07:08 2021

@author: Pablo
"""

from pyswip import Prolog
prolog=Prolog()
prolog.assertz("padrede(juan,maria)")
prolog.assertz("padrede(pablo,juan)")
prolog.assertz("padrede(pablo,marcela)")
prolog.assertz("padrede(carlos,debora)")
prolog.assertz("hijode(A, B):- padrede(B,A)")
prolog.assertz("abuelode(A, B) :- padrede(A,C), padrede(C,B)")
prolog.assertz("hermanode(A, B):- padrede(C,A), padrede(C,B), A\=B")

for elemento in prolog.query("padrede(X,Y)"):
    print(elemento["X"], "Es el padre de ", elemento["Y"])
    
for elemento in prolog.query("hijode(X,Y)"):
    print(elemento["X"], "Es el hijo de ", elemento["Y"])

for elemento in prolog.query("abuelode(X,Y)"):
    print(elemento["X"], "Es el abuelo de  ", elemento["Y"])
  
for elemento in prolog.query("hermanode(X,Y)"):
    print(elemento["X"], "Es el hermano de ", elemento["Y"])  
    
