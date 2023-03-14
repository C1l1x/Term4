(DEFUN Num5 ()
(LET ((Br 0) (S 0))
(LOOP
(SETQ x (READ))
(COND ((= x 0) (SETQ Br (+ Br 1)))
((> x 0) (SETQ S (+ S x)))
((= Br 0) (RETURN S))
 ))))