using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class NewEditModeTest1 {

	[Test]
	public void NewEditModeTest1SimpleFailure() {
		Assert.AreEqual (1, 0);
	}
	
	[UnityTest]
	public IEnumerator NewEditModeTest1WithEnumeratorFailure() {
		Assert.AreEqual (1, 0);
		yield return null;
	}
}
