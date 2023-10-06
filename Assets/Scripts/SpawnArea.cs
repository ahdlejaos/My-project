using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

[DisallowMultipleComponent, SelectionBase]
public class SpawnArea : MonoBehaviour
{
	[Header("스폰 지점 설정")]
	public bool insertCentrePoint = false;
	public bool isRandom = false;
	[Header("스폰 지점 목록")]
	public List<Vector3> relativePoints;
	[SerializeField] List<Vector3> randomizedPoints;

	void Awake()
	{
		if (insertCentrePoint || relativePoints.Count == 0)
		{
			relativePoints.Add(transform.position);
		}

		var renderer = GetComponentInChildren<Renderer>();
		if (renderer)
		{
			Destroy(renderer);
		}
	}
	void Start()
	{
		if (0 < relativePoints.Count)
		{
			randomizedPoints = new(relativePoints);
		}
	}

	public Vector3 GetSpawnPoint(in int index)
	{
		if (isRandom)
		{
			int peek = index % randomizedPoints.Count;

			return randomizedPoints[peek];
		}
		else
		{
			int peek = index % relativePoints.Count;

			return relativePoints[peek];
		}
	}
}
