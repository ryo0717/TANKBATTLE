﻿using UnityEngine;
using System.Collections.Generic;

public class Searching : MonoBehaviour
{
    public event System.Action<GameObject>  onFound = ( obj ) => {};
    public event System.Action<GameObject>  onLost  = ( obj ) => {};

} // class SearchingBehavior