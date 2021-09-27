using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IOperateTouch 
{
  public void OnHandOwer(XRHand hand, ITouchable item);
  public void OnHandEnter(XRHand hand, ITouchable item);
  public void OnHandExit(XRHand hand, ITouchable item);
  public void OnHandAction(XRHand hand, ITouchable item);
}
