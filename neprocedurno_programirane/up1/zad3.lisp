; Da se definira kombinaciq ot funkcii, koqto ot dadeniq spisak ((apple green) (apple red) (stawberry red) (pear yellow)), da vrushta kato recultat
;   a. apple
;   b. red
;   c. (strawberry red)
;   d. (pear yellow)
;   e. (yellow)
;   f. pear


(write (setq test '((apple green) (apple red) (strawberry red) (pear yellow))))
(fresh-line)
(write (caar test))
(fresh-line)
(write (cdadr test))
(fresh-line)
(write (caddr test))
(fresh-line)
(write (cdddr test))
(fresh-line)
(write (cdar (cdddr test)))
(fresh-line)
(write (caar (cdddr test)))
(fresh-line)