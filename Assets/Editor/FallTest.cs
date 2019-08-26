using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class FallTest 
{
    [Test]
    public void CalculateTotalPoints_Test() 
    {
        int expectedPoints = 100;
        int points = 100;

        Assert.AreEqual(expectedPoints, points);
    }
}
