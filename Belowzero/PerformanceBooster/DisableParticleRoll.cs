using System;
using Unity.Collections;
using UnityEngine;

// Token: 0x02000002 RID: 2
[RequireComponent(typeof(ParticleSystem))]
public class DisableParticleRoll : MonoBehaviour
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	private void Start()
	{
		this.m_ParticleSystem = base.GetComponent<ParticleSystem>();
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002060 File Offset: 0x00000260
	private void LateUpdate()
	{
		if (!MainCamera.camera)
		{
			return;
		}
		NativeArray<ParticleSystem.Particle> nativeArray = new NativeArray<ParticleSystem.Particle>(this.m_ParticleSystem.particleCount, Allocator.Temp, NativeArrayOptions.ClearMemory);
		int particles = this.m_ParticleSystem.GetParticles(nativeArray);
		for (int i = 0; i < particles; i++)
		{
			ParticleSystem.Particle particle = nativeArray[i];
			particle.rotation = 0f;
			nativeArray[i] = particle;
		}
		this.m_ParticleSystem.SetParticles(nativeArray, particles);
		nativeArray.Dispose();
	}

	// Token: 0x04000001 RID: 1
	private ParticleSystem m_ParticleSystem;

	// Token: 0x04000002 RID: 2
	private float m_LastRotation;
}
