﻿namespace HW_3_3.interfaces;

interface IParent : IPrinter
{
    double Average();
    void ReCreate(bool fill_rand);
}