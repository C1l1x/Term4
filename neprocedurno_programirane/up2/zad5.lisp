(defun gw (w)
    (cond ((< -20 w 3) (* 2 w))
          ((and (>= w 3)) (* (- w 1) (- w 1)))
          (t -1)
            ))
(fresh-line)
