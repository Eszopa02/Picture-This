using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowercaseStickers : MonoBehaviour
{
    public GameObject CatOptionsButton;
    public GameObject RandomAssetsButton;
    public GameObject DogOptionsButton;
    public GameObject LowercaseLettersButton;
    public GameObject CapitalLettersButton;

    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public GameObject g;
    public GameObject h;
    public GameObject i;
    public GameObject j;
    public GameObject k;
    public GameObject l;
    public GameObject m;
    public GameObject n;
    public GameObject o;
    public GameObject p;
    public GameObject q;
    public GameObject r;
    public GameObject s;
    public GameObject t;
    public GameObject u;
    public GameObject v;
    public GameObject w;
    public GameObject x;
    public GameObject y;
    public GameObject z;

    public void DeactivateButtons()
    {
        CatOptionsButton.SetActive(false);
        RandomAssetsButton.SetActive(false);
        DogOptionsButton.SetActive(false);
        LowercaseLettersButton.SetActive(false);
        CapitalLettersButton.SetActive(false);

    }

    public void ActivateButtons()
    {
        a.SetActive(true);
        b.SetActive(true);
        c.SetActive(true);
        d.SetActive(true);
        e.SetActive(true);
        f.SetActive(true);
        g.SetActive(true);
        h.SetActive(true);
        i.SetActive(true);
        j.SetActive(true);
        k.SetActive(true);
        l.SetActive(true);
        m.SetActive(true);
        n.SetActive(true);
        o.SetActive(true);
        p.SetActive(true);
        q.SetActive(true);
        r.SetActive(true);
        s.SetActive(true);
        t.SetActive(true);
        u.SetActive(true);
        v.SetActive(true);
        w.SetActive(true);
        x.SetActive(true);
        y.SetActive(true);
        z.SetActive(true);

    }

    public void LettersButton()
    {
        DeactivateButtons();

        ActivateButtons();
    }
}
