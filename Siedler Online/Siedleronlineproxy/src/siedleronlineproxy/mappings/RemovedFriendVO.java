/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

package siedleronlineproxy.mappings;

/**
 *
 * @author nspecht
 */
public class RemovedFriendVO extends GenericMapping {
    public Integer friendRemoverID;
    public Integer removedFriendID;

    @Override
    public void proceed() {
    }

    @Override
    public void manipulate(boolean incoming) {
    }
}
