﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAirplane.Entities;

/// <summary>
/// Базовый класс сущность Самолет
/// </summary>
public class EntityAirplane
{
  /// <summary>
  /// Скорость
  /// </summary>
  public int Speed { get; private set; }

  /// <summary>
  /// Вес
  /// </summary>
  public double Weight { get; private set; }

  /// <summary>
  /// Основной цвет
  /// </summary>
  public Color BodyColor { get; private set; }

  /// <summary>
  /// Шаг перемещения самолета
  /// </summary>
  public double Step => Speed * 100 / Weight;

  /// <summary>
  /// Конструктор сущности
  /// </summary>
  /// <param name="speed">Скорость</param>
  /// <param name="weight">Вес самолета</param>
  /// <param name="bodyColor">Основной цвет</param>
  public EntityAirplane(int speed, double weight, Color bodyColor)
  {
    Speed = speed;
    Weight = weight;
    BodyColor = bodyColor;
  }
}
