using UnityEngine;

public class Raycasting : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public ParticleSystem muzzleFlash;

    public Camera fpsCam;

    public AudioSource source;
    public AudioClip clip;

    // Update is called once per frame
    void Update()
    {

        // Skjuter ut en raycast och spelar skjut ljudet när vänsta musknappen trycks ner
        if(Input.GetButtonDown("Fire1"))
        {
        RaycastHit hit; // Gör så att man kan kalla på RaycastHit genom att skriva hit
        muzzleFlash.Play(); // Spelar upp muzzleflashen när man klickar på vänstra mus knappen
        WallText.shootsFired +=1; // Ökar variabeln ShootsFired i WallText scriptet med 1 när man skjuter
        Debug.Log(WallText.shootsFired); 
        // Om raycasten träffar ett object så kommer den göra skada på objectet och debugga i konsolen vilket objekt den träffade
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.TakeDamage(damage);
                } 
            }
        // Spelar upp ett ljud när man träffar väggen
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range) && hit.transform.tag == "wall")
            {
                source.PlayOneShot(clip);
            }
        }

    }


}
