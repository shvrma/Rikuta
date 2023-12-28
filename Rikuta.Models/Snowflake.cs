﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rikuta.Models;

/// <summary>
/// An identifier object that is used across Discord's internal system.
/// </summary>
/// <param name="Value">An underlying value of Snowflake.</param>
public readonly record struct Snowflake(ulong Value);
